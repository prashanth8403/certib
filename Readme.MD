# Certificate Management Application Components

## A Application

### End User Application
This module will be developed using the ASP.net web framework.

### Blockchain Node Server
This module will be developed using the .Net Network library using C# window form framework.

### Certificate
The user's certificate will be a digital image with embedded information. The same image can be used to verify the authenticity.

## B Certificate Generation and Authentication System

This web portal is used by third parties to verify the authenticity of the certificate. The portal internally utilizes image decoding service and node verification service to check the certificate status.

As the end certificate provided to the user is in the form of a digital image, this service will create an image with an appropriate template and text for the certificate. This sub-system internally uses the OpenGL library to generate the image.

## C System Architecture

The three major components of the system are:

1. **Cluster of Nodes forming Blockchain**
   - All certificate-related data is stored in a distributed hyperledger format across multiple nodes.
   - This enables node synchronization and node verification.

2. **Certificate Generation Portal**
   - The certificate to be issued can be created using a web portal.
   - Upon approval by the concerned authority, it can be added to the blockchain network.
   - The end certificate provided to the user will be in the form of a digital image with encrypted certificate information embedded in it.

3. **Certificate Authentication Portal**
   - Third parties can verify the authenticity of the certificate using this portal.
   - Certificate information is extracted from the image and verified with at least two nodes in the blockchain network.
   - Appropriate status is provided, and the query info is saved to a queue for historical references.

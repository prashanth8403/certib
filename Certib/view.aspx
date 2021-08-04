<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view.aspx.cs" Inherits="Certib.view" %>


<!DOCTYPE html>
<html lang="en">

<head>
    <!-- TITLE -->
    <link href="Resource/Styles/certificate.css" rel="stylesheet" />
    <title>VERIFICATION&nbsp;&nbsp;|&nbsp;&nbsp;Certib
    </title>
    <!-- MOBILE VIEW ADJUSTMENT TAG -->
    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0, shrink-to-fit=no' name='viewport' />
    <!-- FAVICON ICON -->
    <link rel="icon" type="image/png" href="Resource/Images/logo.png">
    <!-- FONTS  & ICONS -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons|Pacifico&display=swap" type="text/css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css">
    <!-- STYLESHEET -->
    <link rel="stylesheet" href="Resource/Styles/styles.css" />
</head>

<body>
    <nav class="navbar navbar-transparent fixed-top navbar-expand-lg" id="sectionsNav">
        <div class="container">
            <div class="navbar-translate">
                <div>
                    <div style="float: left; padding-right: 10px;">
                        <img id="logoid" src="Resource/Images/logo.png" height="60" />
                    </div>
                    <div style="float: right; padding-top: 10px;">
                        <a id="bmsit1" class="bmsit-text">BMS</a><br />
                        <a id="bmsit2" class="bmsit-text-s">INSTITUTE OF TECHNOLOGY</a>
                    </div>
                </div>
                <button class="navbar-toggler" type="button" data-toggle="collapse" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="navbar-toggler-icon"></span>
                    <span class="navbar-toggler-icon"></span>
                    <span class="navbar-toggler-icon"></span>
                </button>
            </div>
            <div class="collapse navbar-collapse">
                <ul class="navbar-nav ml-auto">
                    <li class="nav-item">
                        <a class="nav-link" href="Home">
                            <i class="material-icons">home</i>Home
                        </a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">
                            <i class="material-icons">info</i> About
                        </a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <div class="page-header" style="filter: blur(3px); background-image: url('Resource/Images/main-bg/bg7.jpg');">
    </div>
    <form id="LoginPage" runat="server">
        <div class="container" style="margin-top: -100vh; padding-top: 15vh;">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Panel ID="ViewPanel" runat="server">
                        <div class="update-progress">
                            <div class="modal-load">
                                <div id="modal2" class="modal-content">
                                    <div class="certificate-web-template">
                                        <div class="certificate-header">
                                            <div style="max-width: 320px;">
                                                <div style="float: left; padding-right: 10px;">
                                                    <img id="logoid" src="../Resource/Images/logo.png" height="60" />
                                                </div>
                                                <div style="float: right; padding-top: 10px;">
                                                    <a id="bmsit1" class="bmsit-text">BMS</a><br />
                                                    <a id="bmsit2" class="bmsit-text-s">INSTITUTE OF TECHNOLOGY</a>
                                                </div>
                                            </div>
                                            <br />
                                            <br />
                                            <br />
                                            <br />
                                            <a style="font-family: Arial; font-size: 20px; color: #722806">Certificate No: 
                                                                <a style="text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 18px;">
                                                                    <asp:Label ID="certificateno" runat="server" Text="ANC-00853-01"></asp:Label></a>
                                            </a>
                                            <br />
                                            <a style="font-family: Arial; font-size: 20px; color: #722806">Date : 
                                                                <a style="text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 18px;">
                                                                    <asp:Label ID="certificatedate" runat="server" Text="ANC-00853-01"></asp:Label></a>
                                            </a>
                                            <br />

                                            <div style="justify-content: center; text-align: center; width: 100%;">
                                                <a style="font-family: Monotype Corsiva; color: #0094ff; font-size: 35px;">Certificate of Graduation</a><br />
                                                <div style="margin-left: auto; margin-right: auto; position: center;"><a style="font-family: 'Nirmala UI'; color: #15202b; font-size: 20px;">is awarded to</a></div>
                                            </div>
                                            <br />
                                            <p style="width: 60%; margin-left: auto; text-align: center; margin-right: auto;">
                                                <a style="text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 25px;">
                                                    <asp:Label ID="fullname" runat="server" Text="PRASHANTH KUMAR"></asp:Label><asp:Label ID="usn" runat="server" Text="PRASHANTH KUMAR"></asp:Label></a>
                                                <br />
                                                <a style="font-size: 20px;">who has satisfactorily pursued the studies, passed the examination and securing </a>
                                                <a style="text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 20px;">
                                                    <asp:Label ID="marks" runat="server" Text="475/100 (97.5%)"></asp:Label></a>
                                                <a style="font-size: 20px;">and complied with all other requirements.</a>
                                                <a style="text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-size: 20px;"></a>
                                                <br />
                                                <br />
                                                <a style="font-size: 20px;">Therefore, Bachelors degree in </a>
                                                <a style="text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 20px;">
                                                    <asp:Label ID="department" runat="server" Text="Computer science and Engineering"></asp:Label></a>,
                                                                <a style="font-size: 20px;">Graduation year </a>
                                                <a style="text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 20px;">
                                                    <asp:Label ID="year" runat="server" Text="2017-2021"></asp:Label></a>
                                            </p>
                                        </div>
                                    </div>
                                    <div class="footer" style="position: center; margin-left: auto; margin-right: auto;">
                                        <asp:Button ID="ApprovalButton" CssClass="btn btn-danger" runat="server" Text="CLOSE" OnClick="ApprovalButton_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </asp:Panel>
                    <asp:Panel ID="ErrorPanel" runat="server">
                        <div class="update-progress" style="z-index: 1000;">
                            <div class="modal-load">
                                <div class="modal-content ml-auto mr-auto" style="margin-top: 80px; max-width: 600px;">
                                    <div class="modal-body">
                                        <div style="width: 80px; position: center; margin-left: auto; margin-right: auto;">
                                            <img src="../Resource/Images/error.png" height="80" width="80" />
                                        </div>
                                        <div style="text-align: center; padding-top: 20px;">
                                            <a style="padding-top: 60px; font-family: Calibri; font-size: 30px; font-weight: 600;">Process Couldn't be completed!.</a>
                                        </div>
                                        <br />
                                        <p style="text-align: center; font-family: Verdana, Roboto; padding-left: 8px; font-size: 15px; font-weight: 400">
                                            <asp:Label ID="SuccessMessage" runat="server" Text="The submitted certificate is invalid or tampered"></asp:Label><br />
                                        </p>
                                    </div>

                                    <div class="footer" style="position: center; margin-left: auto; margin-right: auto;">
                                        <a class="btn btn-danger" href="/">OK</a>
                                    </div>
                                    <br />
                                </div>
                            </div>
                        </div>
                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
    <!-- SCRIPTS -->
    <script src="Resource/Scripts/core/jquery.min.js" type="text/javascript"></script>
    <script src="Resource/Scripts/core/bootstrap-material-design.min.js" type="text/javascript"></script>
    <script src="Resource/Scripts/silicon.js" type="text/javascript"></script>
</body>

</html>

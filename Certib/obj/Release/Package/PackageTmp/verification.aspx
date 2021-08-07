<%@ Page Language="C#" UnobtrusiveValidationMode="None" AutoEventWireup="true" CodeBehind="verification.aspx.cs" Inherits="Certib.verification" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <!-- TITLE -->
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
                    <div class="row">
                        <div class="col-lg-4 col-md-6 ml-auto mr-auto">
                            <div class="card card-login">
                                <!-- LOGIN SECTION -->
                                <div class="card-body" style="">
                                    <div class="logo">
                                        <br />
                                        <a>Certib</a><br />
                                        <a style="font-family: Arial; color: #ff6a00; font-weight: 600; font-size: 25px;">VERIFICATION</a>
                                    </div>
                                    <br />
                                    
                                    <div class="text-center">
                                        <asp:Label ID="message" runat="server" Text=""></asp:Label>
                                        <br />
                                        <br />
                                        <asp:FileUpload ID="FileUpload1" runat="server" />
                                        <br />
                                        <asp:Button ID="LoginButton" class="btn btn-info" runat="server" Text="SUBMIT" OnClick="LoginButton_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
    </form>
    <!-- SCRIPTS -->
    <script src="Resource/Scripts/core/jquery.min.js" type="text/javascript"></script>
    <script src="Resource/Scripts/core/bootstrap-material-design.min.js" type="text/javascript"></script>
    <script src="Resource/Scripts/silicon.js" type="text/javascript"></script>
</body>

</html>

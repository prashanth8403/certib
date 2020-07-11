<%@ Page Language="C#" UnobtrusiveValidationMode="None" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Certib.Login" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <!-- TITLE -->
    <title>LOGIN&nbsp;&nbsp;|&nbsp;&nbsp;Certib
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
    <div class="page-header" style="filter: blur(3px); background-image: url('Resource/Images/main-bg/bg102.jpg');">
    </div>
    <form id="LoginPage" runat="server">
        <asp:ScriptManager ID="LoginScriptHandler" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="LoginMainPanel" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <div class="container" style="margin-top: -100vh; padding-top: 15vh;">
                    <div class="row">
                        <div class="col-lg-4 col-md-6 ml-auto mr-auto">
                            <div class="card card-login">
                                <!-- LOGIN SECTION -->
                                <div class="card-body" style="min-height: 450px;">
                                    <div class="logo">
                                        <br />
                                        <a>Certib</a>
                                    </div>
                                    <br />
                                    <div class="text-center">
                                        <asp:Label ID="LoginLabel" CssClass="error-label" runat="server" Text="Mike tango"></asp:Label>
                                    </div>
                                    <br />
                                    <div class="validation-container">
                                        <asp:RegularExpressionValidator
                                            ID="UserIDValid"
                                            CssClass="validation-class-text" runat="server"
                                            ErrorMessage=" *Invalid Email"
                                            ControlToValidate="_userid"
                                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                            Display="Dynamic">
                                            <a Class="validation-class-text"><i class="material-icons">error_outline</i>&nbsp;Invalid Email</a>
                                        </asp:RegularExpressionValidator>
                                        <asp:RequiredFieldValidator CssClass="validation-class-text" ControlToValidate="_userid" ID="UserIDRequired" runat="server" ErrorMessage="*Enter UserID">
                                        <a Class="validation-class-text"><i class="material-icons">error_outline</i>&nbsp;Enter Email</a>
                                        </asp:RequiredFieldValidator>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-prepend">
                                            <span class="input-group-text">
                                                <i class="material-icons">face</i>
                                            </span>
                                        </div>
                                        <asp:TextBox ID="_userid" class="form-control" placeholder="Email..." runat="server"></asp:TextBox>
                                    </div>
                                    <div class="validation-container">
                                        <asp:RequiredFieldValidator CssClass="validation-class-text" ControlToValidate="_password" ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Enter Password">
                                            <a Class="validation-class-text"><i class="material-icons">error_outline</i>&nbsp;Enter Password</a>
                                        </asp:RequiredFieldValidator>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-prepend">
                                            <span class="input-group-text">
                                                <i class="material-icons">lock</i>
                                            </span>
                                        </div>
                                        <asp:TextBox ID="_password" class="form-control" TextMode="Password" placeholder="Password..." runat="server"></asp:TextBox>
                                    </div>
                                    <div class="text-center">
                                        <br />
                                        <br />
                                        <asp:Button ID="LoginButton" class="btn btn-info" runat="server" Text="LOGIN" OnClick="LoginButton_Click" />
                                    </div>
                                    <br />
                                    <br />
                                    <br />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="LoginButton" />
            </Triggers>
        </asp:UpdatePanel>
    </form>
    <!-- SCRIPTS -->
    <script src="Resource/Scripts/core/jquery.min.js" type="text/javascript"></script>
    <script src="Resource/Scripts/core/bootstrap-material-design.min.js" type="text/javascript"></script>
    <script src="Resource/Scripts/silicon.js" type="text/javascript"></script>
</body>

</html>

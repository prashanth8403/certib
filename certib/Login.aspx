<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="certib.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <link rel="icon" type="image/png" href="Resource/Images/logo.png">
    <title>
        Certib - BMSIT&M
    </title>
    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0, shrink-to-fit=no' name='viewport' />
    <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css">
    <link href="Resource/Styles/styles.css" rel="stylesheet" />
</head>
<body class="login-page sidebar-collapse">
    <form id="form1" runat="server">
        <nav class="navbar navbar-transparent navbar-color-on-scroll fixed-top navbar-expand-lg" color-on-scroll="100" id="sectionsNav">
        <div class="container">
            <div class="navbar-translate">
                <div>
                    <div style="float: left; padding-right: 10px;">
                        <img src="Resource/Images/logo.png" height="60" />
                    </div>
                    <div style="float: right; padding-top: 10px;">
                        <a style="font-family: Arial; font-size: 32px; color: #d30000; font-weight: 600">BMS</a><br />
                        <a style="font-family: Calibri; color: #363491; font-size: 22px; font-weight: 600">INSTITUTE OF TECHNOLOGY</a>
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
                        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="nav-link" NavigateUrl="Default.aspx" onclick="scrollToDownload()">
                            <i class="material-icons">home</i>Home
                        </asp:HyperLink>
                    </li>
                    <li class="nav-item">
                        <asp:HyperLink ID="HyperLink2" CssClass="nav-link" NavigateUrl="About.aspx"  onclick="scrollToDownload()" runat="server">
                            <i class="material-icons">info</i> About
                        </asp:HyperLink>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <div class="page-header" style="background-image: url('Resource/Images/bg9.jpg'); background-size: cover; background-position: top center;">
        <div class="container">
            <div class="row">
                <div class="col-lg-4 col-md-6 ml-auto mr-auto">
                    <div class="card card-login">
                        <div class="form">
                            <div class="card-header card-header-primary text-center">
                                <h4 class="card-title">Login</h4>
                            </div>
                            <br />

                            <div class="card-body">
                                <div class="input-group">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text">
                                            <i class="material-icons">face</i>
                                        </span>
                                    </div>
                                    <asp:TextBox ID="TextBox1" CssClass="form-control" placeholder="User Id..." runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text">
                                            <i class="material-icons">mail</i>
                                        </span>
                                    </div>
                                    <asp:TextBox ID="TextBox2" CssClass="form-control" placeholder="Email..." runat="server"></asp:TextBox>
                                </div>
                                <div class="input-group">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text">
                                            <i class="material-icons">lock</i>
                                        </span>
                                    </div>
                                    <asp:TextBox ID="TextBox3" CssClass="form-control" placeholder="Password..." runat="server"></asp:TextBox>
                                </div>

                            </div>
                            <br />
                            <br />
                            <div class="text-center">
                                <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Login" />
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
        <footer class="footer">
            <div class="container">

            </div>
        </footer>
    </div>
    <script src="Resource/Scripts/core/jquery.min.js" type="text/javascript"></script>
    <script src="Resource/Scripts/core/popper.min.js" type="text/javascript"></script>
    <script src="Resource/Scripts/core/bootstrap-material-design.min.js" type="text/javascript"></script>
    <script src="Resource/Scripts/silicon.js" type="text/javascript"></script>
    </form>
</body>
</html>

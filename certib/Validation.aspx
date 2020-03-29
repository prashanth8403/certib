<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validation.aspx.cs" Inherits="certib.Validation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <link rel="icon" type="image/png" href="Resource/Images/logo.png">
    <title>Validation</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons" />
    <link rel="stylesheet" href="css/font-awesome.min.css">
    <link href="Resource/Styles/styles.css" rel="stylesheet" />
</head>
<body class="certvalid">
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
    <div class="cert-box" align="center" ng-app="">
        <span class="blue-box">VALIDATION</span>
        <div class="secn1">
            <div class="iconplace1">
                <i class="fa fa-certificate"></i>
            </div>
            <div class="divalign"  ng-class="{'not-empty': userName.length}">
                <asp:TextBox ID="cnum" CssClass="certnum" name="cnum" ng-model="userName" runat="server"></asp:TextBox>
                <label for="cnum" class="animated-label">Certificate No</label>
            </div>
        </div>
        <br />
        <div class="secn1">
            <div class="iconplace2" style="margin-top:-5px;">
                <i class="material-icons" >lock</i>
            </div>
            <div class="divalign" style="margin-top:-30px;" ng-class="{'not-empty': key.length}">
                <asp:TextBox ID="ckey" CssClass="certnum" name="ckey" ng-model="key" runat="server"></asp:TextBox>
                <label for="ckey" class="animated-label">Certificate Key</label>
            </div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="SUBMIT" CssClass="btn btn-primary" style="background-color:#132ec1;" />

    </div>
    <footer class="footer">
        <div class="container">

        </div>
    </footer>
    </form>
</body>
</html>

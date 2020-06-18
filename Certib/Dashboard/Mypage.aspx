﻿<%@ Page Title="Dashboard" Language="C#" AutoEventWireup="true" CodeBehind="Mypage.aspx.cs" Inherits="Certib.Dashboard.Mypage" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <title><%: Page.Title %>&nbsp;&nbsp;|&nbsp;&nbsp;Certib</title>
    <!-- MOBILE VIEW ADJUSTMENT TAG -->
    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0, shrink-to-fit=no' name='viewport' />
    <!-- FAVICON ICON -->
    <link rel="icon" type="image/png" href="../Resource/Images/favicon.ico">
    <!-- FONTS  & ICONS -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons|Pacifico&display=swap" type="text/css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css">
    <!-- STYLESHEET -->
    <link href="../Resource/Styles/bengaluru.css" rel="stylesheet" />
</head>

<body>
    <div class="wrapper">
        <div class="sidebar" data-color="azure" data-background-color="white" data-image="../Resource/Images/misc/SideBar0.png">
            <div class="logo">
                <div>
                    <img src="../Resource/Images/favicon.ico" />
                    <br />
                    <br />
                    <a style="padding-top: 5px;">Certib</a>
                </div>
            </div>
            <div class="sidebar-wrapper">
                <div class="user">
                    <ul class="nav">
                        <li class="nav-item ">
                            <a class="nav-link" data-toggle="collapse" href="#UserCollapse">
                                <div class="photo" style="margin-left: -9px;">
                                    <i class="material-icons">person_outline</i>
                                </div>
                                <p>
                                    <asp:Label ID="_UserName" runat="server" Text="Defaul Name"></asp:Label>    
                                    <b class="caret"></b>
                                </p>
                            </a>
                            <div class="collapse" id="UserCollapse">
                                <ul class="nav">
                                    <li class="nav-item ">
                                        <a class="nav-link" href="#">
                                            <span class="sidebar-mini"><i class="material-icons">person</i></span>
                                            <span class="sidebar-normal">User Profile </span>
                                        </a>
                                    </li>
                                    <li class="nav-item ">
                                        <a class="nav-link" href="#">
                                            <span class="sidebar-mini"><i class="material-icons">settings</i></span>
                                            <span class="sidebar-normal">Settings </span>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </li>
                    </ul>
                </div>
                <ul class="nav">
                    <li class="nav-item active ">
                        <a class="nav-link" href="Mypage">
                            <i class="material-icons">home</i>
                            <p>Dashboard </p>
                        </a>
                    </li>
                    <li class="nav-item ">
                        <a class="nav-link" data-toggle="collapse" href="#Certificates">
                            <i class="material-icons">aspect_ratio</i>
                            <p>Certificate <b class="caret"></b></p>
                        </a>
                        <div class="collapse" id="Certificates">
                            <ul class="nav">
                                <li class="nav-item ">
                                    <a class="nav-link" href="Certificate">
                                        <span class="sidebar-mini"><i class="material-icons">description</i></span>
                                        <span class="sidebar-normal">Issue Certificate </span>
                                    </a>
                                </li>
                                <li class="nav-item ">
                                    <a class="nav-link" href="#">
                                        <span class="sidebar-mini"><i class="material-icons">how_to_reg</i></span>
                                        <span class="sidebar-normal">Approve Certificate </span>
                                    </a>
                                </li>
                                <li class="nav-item ">
                                    <a class="nav-link" href="#">
                                        <span class="sidebar-mini"><i class="material-icons">view_module</i></span>
                                        <span class="sidebar-normal">Option 3 </span>
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </li>
                    <br />
                    <br />
                    <li class="nav-item ">
                        <a class="nav-link" href="#">
                            <i class="material-icons">power_settings_new</i>
                            <p>Logout </p>
                        </a>
                    </li>
                </ul>
            </div>
        </div>
        <div class="main-panel">
            <nav class="navbar navbar-expand-lg navbar-transparent navbar-absolute fixed-top ">
                <div class="container-fluid">
                    <div class="navbar-wrapper">
                        <a class="navbar-brand" href="#rook">Dashboard</a>
                    </div>
                    <button class="navbar-toggler" type="button" data-toggle="collapse" aria-controls="navigation-index" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="navbar-toggler-icon icon-bar"></span>
                        <span class="navbar-toggler-icon icon-bar"></span>
                        <span class="navbar-toggler-icon icon-bar"></span>
                    </button>
                </div>
            </nav>
            <!-- End Navbar -->
            <div class="content">
                <div class="content">
                    <div class="container-fluid">
                        <div class="row">
                            <div class="col-lg-3 col-md-6 col-sm-6">
                                <div class="card card-stats">
                                    <div class="card-header card-header-warning card-header-icon">
                                        <div class="card-icon">
                                            <i class="material-icons">assignment</i>
                                        </div>
                                        <p class="card-category">Validation Pending</p>
                                        <h3 class="card-title">
                                            <asp:Label ID="_PendingLabel" runat="server" Text="00"></asp:Label>
                                        </h3>
                                    </div>
                                    <div class="card-footer">
                                        <div class="stats">
                                            <i class="material-icons">update</i>
                                            &nbsp;Just now
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-3 col-md-6 col-sm-6">
                                <div class="card card-stats">
                                    <div class="card-header card-header-rose card-header-icon">
                                        <div class="card-icon">
                                            <i class="material-icons">done_outline</i>
                                        </div>
                                        <p class="card-category">Certificates Approved</p>
                                        <h3 class="card-title">
                                            <asp:Label ID="_ApprovedLabel" runat="server" Text="00"></asp:Label>
                                        </h3>
                                    </div>
                                    <div class="card-footer">
                                        <div class="stats">
                                            <i class="material-icons">update</i>
                                             &nbsp;Just now
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-3 col-md-6 col-sm-6">
                                <div class="card card-stats">
                                    <div class="card-header card-header-info card-header-icon">
                                        <div class="card-icon">
                                            <i class="material-icons">addchart</i>
                                        </div>
                                        <p class="card-category">Certificates Issued</p>
                                        <h3 class="card-title">
                                            <asp:Label ID="_CertificatesIssued" runat="server" Text="00"></asp:Label>
                                        </h3>
                                    </div>
                                    <div class="card-footer">
                                        <div class="stats">
                                            <i class="material-icons">date_range</i> Last 24 Hours
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-3 col-md-6 col-sm-6">
                                <div class="card card-stats">
                                    <div class="card-header card-header-success card-header-icon">
                                        <div class="card-icon">
                                            <i class="material-icons">verified_user</i>
                                        </div>
                                        <p class="card-category">Certificates Viewed</p>
                                        <h3 class="card-title">
                                            <asp:Label ID="_CertificatesViewed" runat="server" Text="00"></asp:Label>
                                        </h3>
                                    </div>
                                    <div class="card-footer">
                                        <div class="stats">
                                            <i class="material-icons">date_range</i> Last 24 Hours
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <div class="card">
                                    <div class="card-body">
                                        asd
                                    </div>
                                    <div class="card-footer">
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <footer class="footer">
                <div class="container-fluid">
                    <nav class="float-left">
                        <ul>
                            <li>
                                <a href="#">&copy;
                                <script>
                                    document.write(new Date().getFullYear())
                                </script>
                                    Certib.
                                </a>
                            </li>
                        </ul>
                    </nav>
                </div>
            </footer>
        </div>
    </div>
    <script src="../Resource/Scripts/core/jquery.min.js" type="text/javascript"></script>
    <script src="../Resource/Scripts/core/popper.min.js" type="text/javascript"></script>
    <script src="../Resource/Scripts/core/dashboard-bootstrap.js"></script>
    <script src="../Resource/Scripts/plugins/perfect-scrollbar.jquery.min.js"></script>
    <script src="../Resource/Scripts/dashboard.js"></script>
</body>
</html>

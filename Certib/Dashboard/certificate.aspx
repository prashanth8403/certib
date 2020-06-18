<%@ Page Language="C#" Title="Certificate" AutoEventWireup="true" CodeBehind="certificate.aspx.cs" Inherits="Certib.Dashboard.certificate" %>

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
                    <li class="nav-item">
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
                        <div class="collapse show" id="Certificates">
                            <ul class="nav">
                                <li class="nav-item active">
                                    <a class="nav-link" href="#">
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
                        <a class="navbar-brand" href="#rook">Certificate</a>
                    </div>
                    <button class="navbar-toggler" type="button" data-toggle="collapse" aria-controls="navigation-index" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="navbar-toggler-icon icon-bar"></span>
                        <span class="navbar-toggler-icon icon-bar"></span>
                        <span class="navbar-toggler-icon icon-bar"></span>
                    </button>
                </div>
            </nav>
            <div class="content">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-md-8">
                            <div class="card">
                                <div class="card-header card-header-icon card-header-info">
                                    <div class="card-icon">
                                        <i class="material-icons">api</i>
                                    </div>
                                    <h4 class="card-title">Certificate Form -
                                    <small class="category">fill out the following details</small>
                                    </h4>
                                </div>
                                <div class="card-body">
                                    <form id="temp" runat="server">
                                        <div class="row">
                                            <div class="col-md-6">
                                                <div class="form-group">
                                                    <label class="bmd-label-floating">Username</label>
                                                    <input type="text" class="form-control">
                                                </div>
                                            </div>
                                            <div class="col-md-6">
                                                <div class="form-group">
                                                    <label class="bmd-label-floating">Email address</label>
                                                    <input type="email" class="form-control">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6">
                                                <div class="form-group">
                                                    <label class="bmd-label-floating">Fist Name</label>
                                                    <input type="text" class="form-control">
                                                </div>
                                            </div>
                                            <div class="col-md-6">
                                                <div class="form-group">
                                                    <label class="bmd-label-floating">Last Name</label>
                                                    <input type="text" class="form-control">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="bmd-label-floating">Adress</label>
                                                    <input type="text" class="form-control">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-4">
                                                <div class="form-group">
                                                    <label class="bmd-label-floating">City</label>
                                                    <input type="text" class="form-control">
                                                </div>
                                            </div>
                                            <div class="col-md-4">
                                                <div class="form-group">
                                                    <label class="bmd-label-floating">Country</label>
                                                    <input type="text" class="form-control">
                                                </div>
                                            </div>
                                            <div class="col-md-4">
                                                <div class="form-group">
                                                    <label class="bmd-label-floating">Postal Code</label>
                                                    <input type="text" class="form-control">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label>Description</label>
                                                    <div class="form-group">
                                                        <textarea class="form-control" rows="5"></textarea>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <button type="submit" class="btn btn-info pull-right">Next</button>
                                        <div class="clearfix"></div>
                                    </form>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="card card-profile">
                                <div class="card-body">
                                    <h6 class="card-category text-gray">Certificate</h6>
                                    <p>
                                        [Certificate Preview ]
                                    </p>
                                    <a href="#" class="btn btn-info btn-round">Preview Certificate</a>
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

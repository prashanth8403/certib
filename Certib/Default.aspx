<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Certib.Default" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <!-- TITLE -->
    <title>HOME&nbsp&nbsp|&nbsp&nbsp Certib
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

<body class="index-page sidebar-collapse">
    <form id="form1" style="margin-bottom: 0px;">
        <nav class="navbar navbar-color-on-scroll navbar-transparent fixed-top  navbar-expand-lg" color-on-scroll="100" id="sectionsNav">
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
                            <a class="nav-link" href="Login">
                                <i class="material-icons">perm_identity</i> Login
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
        <div class="page-header" style="height: 100vh; background-image: url('Resource/Images/main-bg/bg13.jpg');">
            <div class="container">
                <div class="row">
                    <div class="col-md-8 ml-auto mr-auto">
                        <div class="brand">
                            <h1>Certib</h1>
                            <h3>A Digital Certificate portal.</h3>
                            <br />
                            <a href="#" class="btn btn-warning">Know more</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="main main-raised">
            <section id="info-section">
                <div class="section section-feature">
                    <div class="container">
                        <div class="container-fluid text-center">
                            <div class="row">
                                <div class="col-md-4">
                                    <div class="feature-tab">
                                        <h4 style="color: red;"><b><i class="material-icons md-48">fingerprint</i></b></h4>
                                        <p>
                                            This portal provides high data security for personal information.
                                        The certificates issued from the portal cannot be fabricated as
                                        we use blockchain technology and provide various levels of authentication.
                                        </p>
                                    </div>
                                    <br />
                                </div>
                                <div class="col-md-4">
                                    <div class="feature-tab">
                                        <h4 style="color: #808080;"><b class="feature-icon"><i class="material-icons md-48">swap_horiz</i></b></h4>
                                        <p>
                                            The portal can be accessed from all types of devices with varying
                                        screen sizes. It's highly responsive on all platforms.
                                        </p>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="feature-tab">
                                        <h4 style="color: #af3ae2;"><b><i class="material-icons md-48">autorenew</i></b></h4>
                                        <p>
                                            The system automatically generates certificates on completion of
                                        the event.
                                        </p>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <br />
                            <div class="row">
                                <div class="col-md-4">
                                    <div class="feature-tab">
                                        <h4 style="color: #ff6a00;"><b><i class="material-icons md-48">touch_app</i></b></h4>
                                        <p>
                                            Efficient user interface design and usability option. The portal also
                                        gives high performance.
                                        </p>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="feature-tab">
                                        <h4 style="color: #0278c1"><b><i class="material-icons md-48">headset_mic</i></b></h4>
                                        <p>
                                            The portal includes a one click access to phone number and email-id
                                        for any of your queries.
                                        </p>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="feature-tab">
                                        <h4 style="color: #079619;"><b><i class="material-icons md-48">verified_user</i></b></h4>
                                        <p>Content goes here </p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </div>
        <div>
            <footer>
                <div class="container-fluid text-center" style="margin: 30px;">
                    <div class="row">
                        <div class="col-md-4" style="padding-left: 25px; padding-right: 25px;">
                            <div class="feature-tab">
                                <br />
                                <p style="font-size: 17px;">
                                    This portal provides high data security for personal information.
                                    The certificates issued from the portal cannot be fabricated as
                                    we use blockchain technology and provide various levels of authentication.
                                </p>
                            </div>
                        </div>
                        <br />
                        <div class="col-md-4" style="padding-left: 25px; padding-right: 25px;">
                            <div class="feature-tab">
                                <h4 style="color: #00ff90; font-size: 22px;"><b>LINKS</b></h4>
                                <p>
                                    The portal can be accessed from all types of devices with varying
                                        screen sizes. It's highly responsive on all platforms.
                                </p>
                            </div>
                        </div>
                        <br />
                        <div class="col-md-4" style="padding-left: 25px; padding-right: 25px;">
                            <div class="feature-tab">
                                <h4 style="color: #00ff90; font-size: 22px;"><b>LINKS</b></h4>
                                <p>
                                    The system automatically generates certificates on completion of
                                        the event.
                                </p>
                            </div>
                        </div>
                    </div>
                    <br />
                    <hr />
                    <a style="color: #fff; float: left;">© 2020 Certib. All Rights Reserved.</a>
                    <br />
                </div>
            </footer>
        </div>
        <script src="Resource/Scripts/core/jquery.min.js" type="text/javascript"></script>
        <script src="Resource/Scripts/core/popper.min.js" type="text/javascript"></script>
        <script src="Resource/Scripts/core/bootstrap-material-design.min.js" type="text/javascript"></script>
        <script src="Resource/Scripts/material-kit.mind1f1.js"></script>
    </form>
</body>
</html>

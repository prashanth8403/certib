﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="certib.Default" %>

<!DOCTYPE html>
<html lang="en">

<head runat="server">
    <meta charset="utf-8" />
    <link rel="icon" type="image/png" href="Resource/Images/logo.png">
    <title>Certib - BMSIT&M
    </title>
    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0, shrink-to-fit=no' name='viewport' />
    <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css">
    <link href="Resource/Styles/styles.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">

</head>

<body class="index-page sidebar-collapse">
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
                            <a class="nav-link" href="login.aspx">
                                <i class="material-icons">perm_identity</i> Login
                            </a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="About.aspx">
                                <i class="material-icons">info</i> About
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
        <div class="page-header" style="height: 100vh; background-image: url('Resource/Images/bg7.jpg');">
            <div class="container">
                <div class="row">
                    <div class="col-md-8 ml-auto mr-auto">
                        <div class="brand">
                            <h1>Certib</h1>
                            <h3>A Digital Certificate portal.</h3>
                            <button class="btn btn-info">Know more</button>
                        </div>

                    </div>
                </div>
            </div>
        </div>
        <div class="main main-raised">
            <div class="section section-download">
                <div class="container">
                    <div class="container-fluid text-center">
                        <div class="row">
                            <div class="col-md-4">
                                <div class="feature-tab">
                                    <h4><b>HIGH RESOLUTION</b></h4>
                                    <p>Content goes here </p>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="feature-tab">
                                    <h4><b>HIGH RESOLUTION</b></h4>
                                    <p>Content goes here </p>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="feature-tab">
                                    <h4><b>HIGH RESOLUTION</b></h4>
                                    <p>Content goes here </p>
                                </div>
                            </div>

                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <div class="feature-tab">
                                    <h4><b>HIGH RESOLUTION</b></h4>
                                    <p>Content goes here </p>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="feature-tab">
                                    <h4><b>HIGH RESOLUTION</b></h4>
                                    <p>Content goes here </p>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="feature-tab">
                                    <h4><b>HIGH RESOLUTION</b></h4>
                                    <p>Content goes here </p>
                                </div>
                            </div>

                        </div>
                    </div>
                    <div class="container-fluid text-center">
                        <h2 style="text-align: center; color: darkgray"><b>CHECK OUR FEATURES</b></h2>
                        <br />
                        <img src="Resource/Images/temp.jpg" alt="Features" height="300" />
                    </div>
                </div>
            </div>
        </div>

        <footer class="footer" style="background-color:darkgray">
            <div class="container">
                <div class="container-fluid text-center">
                        <div class="row">
                            <div class="col-md-4">
                                <div class="footer_tab">
                                     <address style="text-align:left">
                                            <h3 style="color:black"><b>CONTACT US</b></h3>
                                            <h4 style="color:black">
                                            <i class="material-icons">location_on</i>&emsp;&nbsp;BMSIT&M<br>
                                            &emsp;&emsp;&ensp;Avalahalli<br>
                                            &emsp;&emsp;&ensp;Bangalore<br>
                                            </h4>
                                             <br>
                                            <a href="tel:+919876543210" style="color:black"><i class="material-icons">phone</i>&emsp;&ensp;9876543210</a>
                                            <br>
                                            <br>
                                            <a href="mailto:contact@bmsit.in" style="color:black"><i class="material-icons">email</i>&emsp;&ensp;contact@bmsit.in</a>

                                    </address>
                               </div>
                            </div>
                            <div class="col-md-4">
                                <div class="footer_tab" style="float:right">
                                     <h3 style="color:black"><b>ABOUT US</b></h3>
                                     <h4 style="color:black">Content goes here</h4>
                                </div>
                            </div>
                            
                            <div class="social_tab">
                                <a href="#" style="color:black"><i class="fa fa-facebook fa-2x circle-icon"></i></a>&nbsp;
                                <a href="#" style="color:black"><i class="fa fa-twitter fa-2x circle-icon"></i></a>&nbsp;
                                <a href="#" style="color:black"><i class="fa fa-google fa-2x circle-icon"></i></a>&nbsp;
                                <a href="#" style="color:black"><i class="fa fa-linkedin fa-2x circle-icon"></i></a>&nbsp;
                                <a href="#" style="color:black"><i class="fa fa-instagram fa-2x circle-icon"></i></a>&nbsp;

                            </div>
                        </div>
                            

            </div>
            </div>
        </footer>

        <script src="Resource/Scripts/core/jquery.min.js" type="text/javascript"></script>
        <script src="Resource/Scripts/core/popper.min.js" type="text/javascript"></script>
        <script src="Resource/Scripts/core/bootstrap-material-design.min.js" type="text/javascript"></script>
        <script src="Resource/Scripts/silicon.js" type="text/javascript"></script>
    </form>
</body>
</html>



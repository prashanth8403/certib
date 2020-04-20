<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Certib_1A.Login" %>



<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8" />
    <link rel="icon" type="image/png" href="Resource/Images/logo.png">
    <title>LOGIN&nbsp&nbsp|&nbsp&nbsp Certib
    </title>
    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0, shrink-to-fit=no' name='viewport' />
    <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons" />
    <link href="https://fonts.googleapis.com/css2?family=Pacifico&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css">
    <link href="Resource/Styles/styles.css" rel="stylesheet" />

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
                        <a class="nav-link" href="#" onclick="scrollToDownload()">
                            <i class="material-icons">home</i>Home
                        </a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#" onclick="scrollToDownload()">
                            <i class="material-icons">info</i> About
                        </a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <div class="page-header" style="filter: blur(9px); background-image: url('Resource/Images/main-bg/bg6a.jpg'); ">
    </div>
     <div class="container" style="margin-top:-100vh; padding-top:15vh;">
            <div class="row" >
                <div class="col-lg-4 col-md-6">
                    <div class="card card-login"  style="z-index:999;">
                        <div class="card-body" style="min-height: 450px;">
                            <div class="logo">
                                <br />
                                <a>Certib</a>
                            </div>
                            <div class="input-group">
                                <div class="input-group-prepend">
                                    <span class="input-group-text">
                                        <i class="material-icons">face</i>
                                    </span>
                                </div>
                                <input type="text" class="form-control" placeholder="User Id...">
                            </div>
                            <div class="input-group">
                                <div class="input-group-prepend">
                                    <span class="input-group-text">
                                        <i class="material-icons">mail</i>
                                    </span>
                                </div>
                                <input type="email" class="form-control" placeholder="Email...">
                            </div>
                            <div class="input-group">
                                <div class="input-group-prepend">
                                    <span class="input-group-text">
                                        <i class="material-icons">mail</i>
                                    </span>
                                </div>
                                <input type="email" class="form-control" placeholder="Email...">
                            </div>
                            <div class="text-center">
                                <br />
                                <br />
                                <button class="btn btn-info">Login</button>
                            </div>
                        </div>
                        <br />
                    </div>
                </div>
            </div>
        </div>
    <script src="Resource/Scripts/core/jquery.min.js" type="text/javascript"></script>
    <script src="Resource/Scripts/core/popper.min.js" type="text/javascript"></script>
    <script src="Resource/Scripts/core/bootstrap-material-design.min.js" type="text/javascript"></script>
    <script src="Resource/Scripts/silicon.js" type="text/javascript"></script>
</body>

</html>

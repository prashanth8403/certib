<%@ Page Title="Dashboard" Language="C#" MasterPageFile="~/Dashboard/Dashboard.Master" AutoEventWireup="true" CodeBehind="Mypage.aspx.cs" Inherits="Certib.Dashboard.Mypage1" %>

<asp:Content ID="SidePanel" ContentPlaceHolderID="SideBar" runat="server">
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
                            <a class="nav-link" href="Profile">
                                <span class="sidebar-mini"><i class="material-icons">person</i></span>
                                <span class="sidebar-normal">User Profile </span>
                            </a>
                        </li>
                        <li class="nav-item ">
                            <a class="nav-link" href="Settings">
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
</asp:Content>
<asp:Content ID="MainPanel" ContentPlaceHolderID="main_content" runat="server">
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
</asp:Content>

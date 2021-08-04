<%@ Page Title="Apprecitation Certificate" Language="C#" MasterPageFile="~/dashboard/Dashboard.Master" AutoEventWireup="true" CodeBehind="misccertificate.aspx.cs" Inherits="Certib.dashboard.degreecertificate" %>

<asp:Content ID="SideBar" ContentPlaceHolderID="SideBar" runat="server">
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
                    <li class="nav-item">
                        <a class="nav-link" href="certificate">
                            <span class="sidebar-mini"><i class="material-icons">description</i></span>
                            <span class="sidebar-normal">Degree Certificate </span>
                        </a>
                    </li>
                    <li class="nav-item  active">
                        <a class="nav-link" href="#">
                            <span class="sidebar-mini"><i class="material-icons">view_module</i></span>
                            <span class="sidebar-normal">Appreciation Certificate </span>
                        </a>
                    </li>
                </ul>
            </div>

        </li>
        <li class="nav-item">
            <a class="nav-link" href="approval">
                <i class="material-icons">how_to_reg</i>
                <p>Approve Certificate </p>
            </a>
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
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label class="bmd-label-floating">Full Name</label>
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
                                        <label class="bmd-label-floating">University Seat Number</label>
                                        <input type="text" class="form-control">
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <asp:DropDownList class="form-control" ID="department_selection" runat="server">
                                            <asp:ListItem Value="0">Select Department</asp:ListItem>
                                            <asp:ListItem Value="Computer Science and Engineering">Computer Science and Engineering</asp:ListItem>
                                            <asp:ListItem Value="Electrical and Electronic Engineering">Electrical and Electronic Engineering</asp:ListItem>
                                            <asp:ListItem Value="Electrical and Communcation Engineering">Electrical and Communcation Engineering</asp:ListItem>
                                            <asp:ListItem Value="Mechanical Engineering">Mechanical Engineering</asp:ListItem>
                                            <asp:ListItem Value="Information and Science Engineering">Information and Science Engineering</asp:ListItem>
                                            <asp:ListItem Value="Mechanical Engineering">Mechanical Engineering</asp:ListItem>
                                            <asp:ListItem Value="Information and Science Engineering">Information and Science Engineering</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label class="bmd-label-floating">Secured Marks</label><br />
                                        <asp:TextBox CssClass="short-text" ID="Marks" runat="server"></asp:TextBox>
                                        of 
                                        <asp:TextBox CssClass="short-text" ID="MaxMarks" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label class="bmd-label-floating">Passing Year</label><br />
                                        <asp:TextBox CssClass="short-text" ID="StartYear" runat="server"></asp:TextBox>
                                        to 
                                        <asp:TextBox CssClass="short-text" ID="EndYear" runat="server"></asp:TextBox>
                                    </div>
                                </div>

                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="form-group">
                                        <label class="bmd-label-floating">Remarks</label>
                                        <input type="text" class="form-control">
                                    </div>
                                </div>
                            </div>
                            <br />
                            <button type="submit" class="btn btn-info pull-right">Next</button>
                            <div class="clearfix"></div>
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
</asp:Content>

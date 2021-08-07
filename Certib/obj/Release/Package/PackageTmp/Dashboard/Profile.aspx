<%@ Page Title="Profile" Language="C#" MasterPageFile="~/Dashboard/Dashboard.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Certib.Dashboard.profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="SideBar" runat="server">
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
                <div class="collapse show" id="UserCollapse">
                    <ul class="nav">
                        <li class="nav-item active">
                            <a class="nav-link" href="#">
                                <span class="sidebar-mini"><i class="material-icons">person</i></span>
                                <span class="sidebar-normal">User Profile </span>
                            </a>
                        </li>
                        <li class="nav-item">
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
            <div class="collapse" id="Certificates">
                <ul class="nav">
                    <li class="nav-item">
                        <a class="nav-link" href="Certificate">
                            <span class="sidebar-mini"><i class="material-icons">description</i></span>
                            <span class="sidebar-normal">Degree Certificate </span>
                        </a>
                    </li>
                    <li class="nav-item ">
                        <a class="nav-link" href="misccertificate">
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
<asp:Content ID="Content2" ContentPlaceHolderID="main_content" runat="server">

</asp:Content>

<%@ Page Title="Dashboard" Language="C#" MasterPageFile="~/Dashboard/Dashboard.Master" AutoEventWireup="true" CodeBehind="mypage.aspx.cs" Inherits="Certib.Dashboard.Mypage1" %>

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
                    <li class="nav-item">
                        <a class="nav-link" href="certificate">
                            <span class="sidebar-mini"><i class="material-icons">description</i></span>
                            <span class="sidebar-normal">Degree Certificate </span>
                        </a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="achivement">
                            <span class="sidebar-mini"><i class="material-icons">view_module</i></span>
                            <span class="sidebar-normal">Achivement Certificate </span>
                        </a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="participation">
                            <span class="sidebar-mini"><i class="material-icons">view_module</i></span>
                            <span class="sidebar-normal">Participation Certificate </span>
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
                    <div class="table-container">
                        <asp:GridView ID="GridFinal" CssClass="customers" runat="server" AutoGenerateColumns="false">
                            <Columns>
                                <asp:BoundField DataField="ID" HeaderText="Index" />
                                <asp:TemplateField HeaderText="Certificate Number">
                                    <ItemTemplate>
                                        <%# Convert.ToInt32(Eval("type")) == 0 ? "ANC00853"+Eval("ID") : Convert.ToInt32(Eval("type"))==1?"JBT00700"+Eval("ID") :"SPRT0500"+Eval("ID")   %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="USN" HeaderText="USN" />
                                <asp:BoundField DataField="Name" HeaderText="Name" />
                                <asp:BoundField DataField="Description" HeaderText="Description" />
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

<%@ Page Title="Apprecitation Certificate" Language="C#" MasterPageFile="~/dashboard/Dashboard.Master" AutoEventWireup="true" CodeBehind="participation.aspx.cs" Inherits="Certib.dashboard.participationcertificate" %>

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
                    <li class="nav-item">
                        <a class="nav-link" href="achivement">
                            <span class="sidebar-mini"><i class="material-icons">view_module</i></span>
                            <span class="sidebar-normal">Achivement Certificate </span>
                        </a>
                    </li>
                    <li class="nav-item active">
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
    <div class="content" style="margin-top: -50px;">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-10 ml-auto mr-auto">
                    <div class="card">
                        <br />
                        <br />
                        <div class="card-header card-header-primary">
                            <h4 class="card-title">Achivement Certificate Form  -
                                    <small class="category">fill out the following details</small>
                            </h4>
                        </div>
                        <div class="card-body">
                            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                            <asp:UpdatePanel ID="CertificateWizard" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:Panel ID="DetailsPanel" runat="server">
                                        <div class="row">
                                            <div class="col-md-6">
                                                <div class="form-group">
                                                    <label class="bmd-label-floating">Full Name</label>
                                                    <asp:TextBox ID="FullName" class="form-control" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div class="col-md-6">
                                                <div class="form-group">
                                                    <label class="bmd-label-floating">Email address</label>
                                                    <asp:TextBox ID="Email" class="form-control" type="email" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6">
                                                <div class="form-group">
                                                    <label class="bmd-label-floating">University Seat Number</label>
                                                    <asp:TextBox ID="Usn" class="form-control" runat="server"></asp:TextBox>
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
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="bmd-label-floating">Achivment/Appreciation</label>
                                                    <asp:TextBox ID="Participation" class="form-control" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="bmd-label-floating">Remarks</label>
                                                    <asp:TextBox ID="Remarks" class="form-control" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                    </asp:Panel>
                                    <asp:Panel ID="ConfirmationPanel" runat="server">
                                        <div class="row">
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <asp:DropDownList class="form-control" ID="Authority" runat="server">
                                                        <asp:ListItem Value="0">Select Authorization Authority</asp:ListItem>
                                                        <asp:ListItem Value="Principal, BMSIT&M">Principal, BMSIT&M</asp:ListItem>
                                                        <asp:ListItem Value="Head of Department">Head of Department</asp:ListItem>
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                        </div>
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                        <div class="row">
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label class="bmd-label-floating">Description</label>
                                                    <asp:TextBox ID="Description" class="form-control" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                    </asp:Panel>
                                    <asp:Panel ID="SucessPanel" runat="server">
                                        <div class="update-progress">
                                            <div class="modal-load">
                                                <div class="modal-content" style="margin-top: 80px;">
                                                    <div class="modal-body">
                                                        <div style="width: 80px; position: center; margin-left: auto; margin-right: auto;">
                                                            <img src="../Resource/Images/tick.png" height="80" width="80" />
                                                        </div>
                                                        <div style="text-align: center; padding-top: 20px;">
                                                            <a style="padding-top: 60px; font-family: Calibri; font-size: 30px; font-weight: 600;">Success!</a>
                                                        </div>
                                                        <br />
                                                        <p style="text-align: center; font-family: Verdana, Roboto; padding-left: 8px; font-size: 15px; font-weight: 400">
                                                            <asp:Label ID="SuccessMessage" runat="server" Text="Certificate Successfully Generated & sent for Approval."></asp:Label><br />
                                                        </p>
                                                    </div>

                                                    <div class="footer" style="position: center; margin-left: auto; margin-right: auto;">
                                                        <a class="btn btn-primary" href="mypage">OK</a>
                                                    </div>
                                                    <br />
                                                </div>
                                            </div>
                                        </div>
                                    </asp:Panel>
                                    <div class="card-body">
                                        <div class="row">
                                            <div class="col-md-12">
                                                <div class="form-group ml-auto mr-0 float-right">
                                                    <asp:Button ID="PrevButton" class="btn btn-dark" runat="server" Text="Previous" OnClick="PrevButton_Click" />
                                                    <asp:Button ID="Button1" class="btn btn-info" runat="server" Text="Next" OnClick="Button1_Click" />
                                                    <div class="clearfix"></div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="Button1" />
                                </Triggers>
                            </asp:UpdatePanel>
                        </div>
                        <br />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/dashboard/Dashboard.Master" AutoEventWireup="true" CodeBehind="approval.aspx.cs" Inherits="Certib.dashboard.approval" %>

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
        <li class="nav-item active">
            <a class="nav-link" href="#">
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
                <div class="col-md-12">
                    <div class="card">
                        <div class="card-header card-header-info">
                            <h4 class="card-title">Certificate Approval
                            </h4>
                        </div>
                        <div class="card-body">
                            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                            <asp:UpdatePanel ID="StatusTable" runat="server">
                                <ContentTemplate>
                                    <asp:Panel ID="TablePanel" runat="server">
                                        <div class="row">
                                            <div class="col-md-12">
                                                <div class="table-container">
                                                    <asp:GridView ID="GridFinal" CssClass="customers" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="GridWithHeld_SelectedIndexChanged">
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
                                                            <asp:ButtonField HeaderText="#" ControlStyle-ForeColor="#363491" ControlStyle-CssClass="info-view" Text="View" CommandName="Select" />
                                                        </Columns>
                                                    </asp:GridView>
                                                </div>
                                            </div>
                                        </div>

                                    </asp:Panel>
                                    <asp:Panel ID="degreecertificate" runat="server">
                                        <div class="update-progress">
                                            <div class="modal-load">
                                                <div id="modal2" class="modal-content">
                                                    <div class="certificate-web-template">
                                                        <div class="certificate-header">
                                                            <div style="max-width: 320px;">
                                                                <div style="float: left; padding-right: 10px;">
                                                                    <img id="logoid" src="../Resource/Images/logo.png" height="60" />
                                                                </div>
                                                                <div style="float: right; padding-top: 10px;">
                                                                    <a id="bmsit1" class="bmsit-text">BMS</a><br />
                                                                    <a id="bmsit2" class="bmsit-text-s">INSTITUTE OF TECHNOLOGY</a>
                                                                </div>
                                                            </div>
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <a style="font-family: Arial; font-size: 20px; color: #722806">Certificate No: 
                                                                <a style="text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 18px;">
                                                                    <asp:Label ID="certificateno" runat="server" Text="ANC-00853-01"></asp:Label></a>
                                                            </a>
                                                            <br />
                                                            <a style="font-family: Arial; font-size: 20px; color: #722806">Date : 
                                                                <a style="text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 18px;">
                                                                    <asp:Label ID="certificatedate" runat="server" Text="ANC-00853-01"></asp:Label></a>
                                                            </a>
                                                            <br />

                                                            <div style="justify-content: center; text-align: center; width: 100%;">
                                                                <a style="font-family: Monotype Corsiva; color: #0094ff; font-size: 35px;">Certificate of Graduation</a><br />
                                                                <div style="margin-left: auto; margin-right: auto; position: center;"><a style="font-family: 'Nirmala UI'; color: #15202b; font-size: 20px;">is awarded to</a></div>
                                                            </div>
                                                            <br />
                                                            <p style="width: 60%; margin-left: auto; text-align: center; margin-right: auto;">
                                                                <a style="text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 25px;">
                                                                    <asp:Label ID="fullname" runat="server" Text="PRASHANTH KUMAR"></asp:Label><asp:Label ID="usn" runat="server" Text="PRASHANTH KUMAR"></asp:Label></a>
                                                                <br />
                                                                <a style="font-size: 20px;">who has satisfactorily pursued the studies, passed the examination and securing </a>
                                                                <a style="text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 20px;">
                                                                    <asp:Label ID="marks" runat="server" Text="475/100 (97.5%)"></asp:Label></a>
                                                                <a style="font-size: 20px;">and complied with all other requirements.</a>
                                                                <a style="text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-size: 20px;"></a>
                                                                <br />
                                                                <br />
                                                                <a style="font-size: 20px;">Therefore, Bachelors degree in </a>
                                                                <a style="text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 20px;">
                                                                    <asp:Label ID="department" runat="server" Text="Computer science and Engineering"></asp:Label></a>,
                                                                <a style="font-size: 20px;">Graduation year </a>
                                                                <a style="text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 20px;">
                                                                    <asp:Label ID="year" runat="server" Text="2017-2021"></asp:Label></a>
                                                            </p>
                                                        </div>
                                                    </div>
                                                    <div class="footer" style="position: center; margin-left: auto; margin-right: auto;">
                                                        <asp:Button ID="ApprovalButton" CssClass="btn btn-primary" runat="server" Text="Approve" OnClick="ApprovalButton_Click" />
                                                        <asp:Button ID="CancelButton" CssClass="btn btn-default" runat="server" Text="Cancel" OnClick="CancelButton_Click" />
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </asp:Panel>
                                    <asp:Panel ID="achivementcertificate" runat="server">
                                        <div class="update-progress">
                                            <div class="modal-load">
                                                <div id="modal2" class="modal-content">
                                                    <div class="certificate-web-template">
                                                        <div class="certificate-header">
                                                            <div style="max-width: 320px;">
                                                                <div style="float: left; padding-right: 10px;">
                                                                    <img id="logoid" src="../Resource/Images/logo.png" height="60" />
                                                                </div>
                                                                <div style="float: right; padding-top: 10px;">
                                                                    <a id="bmsit1" class="bmsit-text">BMS</a><br />
                                                                    <a id="bmsit2" class="bmsit-text-s">INSTITUTE OF TECHNOLOGY</a>
                                                                </div>
                                                            </div>
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <a style="font-family: Arial; font-size: 20px; color: #722806">Certificate No: 
                                                                <a style="text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 18px;">
                                                                    <asp:Label ID="achivementcertificateno" runat="server" Text="ANC-00853-01"></asp:Label></a>
                                                            </a>
                                                            <br />
                                                            <a style="font-family: Arial; font-size: 20px; color: #722806">Date : 
                                                                <a style="text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 18px;">
                                                                    <asp:Label ID="achivementcertificatedate" runat="server" Text="ANC-00853-01"></asp:Label></a>
                                                            </a>
                                                            <br />

                                                            <div style="justify-content: center; text-align: center; width: 100%;">
                                                                <a style="font-family: Arial; color: #0094ff; font-size: 35px;">Certificate of Achivement</a><br />
                                                                <div style="margin-left: auto; margin-right: auto; position: center;"><a style="font-family: 'Nirmala UI'; color: #15202b; font-size: 20px;">is awarded to</a></div>
                                                            </div>
                                                            <br />
                                                            <p style="width: 60%; margin-left: auto; text-align: center; margin-right: auto;">
                                                                <a style="text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 25px;">
                                                                    <asp:Label ID="achivementname" runat="server" Text="PRASHANTH KUMAR"></asp:Label><asp:Label ID="achivmentusn" runat="server" Text="PRASHANTH KUMAR"></asp:Label></a>
                                                                <br />

                                                                <a style="text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 20px;">
                                                                    <asp:Label ID="achivment" runat="server" Text="IEEE Paper"></asp:Label></a><br />
                                                                <a style="font-size: 20px;">is honoured certificate from</a><br />
                                                                <a style="font-size: 20px;">BMS Institute of Technology</a><br />
                                                                <br />
                                                                <br />
                                                                <a style="text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 20px;">
                                                                    <asp:Label ID="achivmenetacademicyear" runat="server" Text="2017-2021"></asp:Label></a>
                                                            </p>
                                                        </div>
                                                    </div>
                                                    <div class="footer" style="position: center; margin-left: auto; margin-right: auto;">
                                                        <asp:Button ID="Button2" CssClass="btn btn-primary" runat="server" Text="Approve" OnClick="ApprovalButton_Click" />
                                                        <asp:Button ID="Button3" CssClass="btn btn-default" runat="server" Text="Cancel" OnClick="CancelButton_Click" />
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </asp:Panel>
                                    <asp:Panel ID="participationcertificate" runat="server">
                                        <div class="update-progress">
                                            <div class="modal-load">
                                                <div id="modal2" class="modal-content">
                                                    <div class="certificate-web-template">
                                                        <div class="certificate-header">
                                                            <div style="max-width: 320px;">
                                                                <div style="float: left; padding-right: 10px;">
                                                                    <img id="logoid" src="../Resource/Images/logo.png" height="60" />
                                                                </div>
                                                                <div style="float: right; padding-top: 10px;">
                                                                    <a id="bmsit1" class="bmsit-text">BMS</a><br />
                                                                    <a id="bmsit2" class="bmsit-text-s">INSTITUTE OF TECHNOLOGY</a>
                                                                </div>
                                                            </div>
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <br />
                                                            <a style="font-family: Arial; font-size: 20px; color: #722806">Certificate No: 
                                                                <a style="text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 18px;">
                                                                    <asp:Label ID="ParticipationCertificateNo" runat="server" Text="ANC-00853-01"></asp:Label></a>
                                                            </a>
                                                            <br />
                                                            <a style="font-family: Arial; font-size: 20px; color: #722806">Date : 
                                                                <a style="text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 18px;">
                                                                    <asp:Label ID="ParticipationCertificateDate" runat="server" Text="ANC-00853-01"></asp:Label></a>
                                                            </a>
                                                            <br />

                                                            <div style="justify-content: center; text-align: center; width: 100%;">
                                                                <a style="font-family: Monotype Corsiva; color: #0094ff; font-size: 35px;">Certificate of Participation</a><br />
                                                                <div style="margin-left: auto; margin-right: auto; position: center;"><a style="font-family: 'Nirmala UI'; color: #15202b; font-size: 20px;">is awarded to</a></div>
                                                            </div>
                                                            <br />
                                                            <p style="width: 60%; margin-left: auto; text-align: center; margin-right: auto;">
                                                                <a style="text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 25px;">
                                                                    <asp:Label ID="participationname" runat="server" Text="PRASHANTH KUMAR"></asp:Label><asp:Label ID="participationUSN" runat="server" Text="PRASHANTH KUMAR"></asp:Label></a>
                                                                <br />
                                                                <a style="text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 20px;">
                                                                    <asp:Label ID="participation" runat="server" Text="IEEE Paper"></asp:Label></a><br />
                                                                <a style="font-size: 20px;">is awarded participation certificate from</a><br />
                                                                <a style="font-size: 20px;">BMS Institute of Technology</a><br />
                                                                <br />
                                                                <br />
                                                                <a style="text-justify: inter-word; font-family: 'Nirmala UI'; color: #15202b; font-weight: 600; font-size: 20px;">
                                                                    <asp:Label ID="participationyear" runat="server" Text="2017-2021"></asp:Label></a>
                                                            </p>
                                                        </div>
                                                    </div>
                                                    <div class="footer" style="position: center; margin-left: auto; margin-right: auto;">
                                                        <asp:Button ID="Button4" CssClass="btn btn-primary" runat="server" Text="Approve" OnClick="ApprovalButton_Click" />
                                                        <asp:Button ID="Button5" CssClass="btn btn-default" runat="server" Text="Cancel" OnClick="CancelButton_Click" />
                                                    </div>
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
                                                            <asp:Label ID="SuccessMessage" runat="server" Text="Certificate Successfully Generated & sent to user."></asp:Label><br />
                                                        </p>
                                                    </div>

                                                    <div class="footer" style="position: center; margin-left: auto; margin-right: auto;">
                                                        <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="OK" OnClick="OKButton_Click" />
                                                    </div>
                                                    <br />
                                                </div>
                                            </div>
                                        </div>
                                    </asp:Panel>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <asp:UpdateProgress ID="UpdateProgress2" runat="server" AssociatedUpdatePanelID="StatusTable">
                                <ProgressTemplate>
                                    <div class="update-progress">
                                        <div id="myModal1" class="modal-load">
                                            <div class="modal-load-content">
                                            </div>
                                        </div>
                                    </div>
                                </ProgressTemplate>
                            </asp:UpdateProgress>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

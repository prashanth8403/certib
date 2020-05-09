<%@ Page Title="SETTINGS" Language="C#" MasterPageFile="~/Dashboard/Dashboard.Master" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="Certib_1A.Dashboard.Settings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="main_content" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container-fluid">
                 <div class="row">
                    <div class="col-md-12">
                        <div class="card">
                            <div class="card-body">
                                <div class="section-cards">
                                    <div class="section-header">
                                        <a>RESET PASSWORD</a>
                                    </div>
                                    <div class="section-body">
                                        <asp:Button CssClass="btn btn-primary" ID="btn_UpdatePassword" runat="server" Text="Submit" />
                                    </div>
                                </div>
                                <div class="section-cards">
                                    <div class="section-header">
                                        <a>UPDATE EMAIL</a>
                                    </div>
                                    <div class="section-body">
                                        <asp:Button CssClass="btn btn-primary" ID="btn_UpdateEmail" runat="server" Text="Submit" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

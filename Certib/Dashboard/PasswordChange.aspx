<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PasswordChange.aspx.cs" Inherits="Certib.Dashboard.PasswordChange" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Change Password</title>
    <link href="../Resource/Styles/Bengaluru.css" rel="stylesheet" />
    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0, shrink-to-fit=no' name='viewport' />
</head>
<body style="background-color: #f0f0f0;">

    <form id="PasswordChangePage" runat="server">
        <div class="col-lg-4 col-md-6 ml-auto mr-auto">
            <div class="card" style="margin-top: 6vh; max-width: 500px;">
                <div class="card-body">
                    <div class="text-center">
                        <h2 class="text-prop">Change Password</h2>
                        <hr />
                        <p class="direction-text">Change your account password below. We recommend using a strong password.</p>
                    </div>
                    <div class="text-center">
                         <asp:Label ID="ChangeLabel" CssClass="error-label" runat="server" Text=""></asp:Label>
                    </div>
                    <br />
                    <div class="input-group">
                        <label for="OldPassword" class="label-text">Old Password</label>
                        <asp:TextBox ID="OldPassword" type="password" runat="server"></asp:TextBox>
                    </div>
                    <div class="input-group">
                        <label for="NewPassword" class="label-text">New Password</label>
                        <asp:TextBox ID="NewPassword" type="password" runat="server"></asp:TextBox>
                    </div>
                    <div class="input-group">
                        <label for="NewAgain" class="label-text">New Password (Again)</label>
                        <asp:TextBox ID="NewAgain" type="password" runat="server"></asp:TextBox>
                    </div>
                    <asp:Label ID="Strength" runat="server" Text="Strength: " CssClass="label-text"></asp:Label>
                    <asp:Label ID="StrengthValue" runat="server" Text="Very Weak (0/100)" CssClass="label-text"></asp:Label>
                    <br />
                    <br />
                    <div class="text-center">
                        <asp:Button ID="SubmitButton" class="btn btn-primary" runat="server" Text="Change your password now!" OnClick="SubmitButton_Click" />
                    </div>
                    <br />
                </div>
            </div>
        </div>
    </form>
</body>
</html>

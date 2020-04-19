<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 448px;
            height: 243px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="align-self:center;margin-left:500px;">
        <div>
            <table class="auto-style1" style="align-self:center">  
                <tr>  
                    <td>ID :</td>  
                    <td>  
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>  
                    </td>  
               </tr>
                <tr>  
                    <td>Name :</td>  
                    <td>  
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>  
                    </td>  
               </tr>
                <tr>  
                    <td>Phone :</td>  
                    <td>  
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>  
                    </td>  
               </tr>
                <tr>  
                    <td>Address :</td>  
                    <td>  
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>  
                    </td>  
               </tr>
                <tr>  
                    <td>Password :</td>  
                    <td>  
                        <asp:TextBox ID="TextBox5" runat="server" TextMode="Password"></asp:TextBox>  
                    </td>  
               </tr>
                <tr>  
                    <td>  
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" style="height: 26px" />  
                    </td>  
                </tr>  
            </table>
        </div>
    </form>
</body>
</html>

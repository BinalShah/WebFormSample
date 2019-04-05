<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>
 
<!DOCTYPE html>  
  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head runat="server">  
    <title>
        Enter Student Data
    </title>  
</head>  
<body>  
    <form id="form1" runat="server">  
        <div>  
            <table class="auto-style1"> 
                 <tr>  
                    <td>ID :</td>  
                    <td>  
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <td>First Name :</td>  
                    <td>  
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>  
                    </td>  
  
               </tr>  
                <tr>  
                    <td>Last Name :</td>  
                     <td> <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>  
                </tr>  
                <tr>  
                    <td>Grade :</td>  
                    <td>  
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>  
                    </td>  
                </tr>  
                 
                <tr>  
                    <td>  
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />  
                    </td>  
                </tr>  
            </table>  
        </div>  
    </form>  

    <asp:HyperLink ID="HyperLink1" NavigateUrl="About.aspx" runat="server">View Student Data</asp:HyperLink>
</body>  
</html>  

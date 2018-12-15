<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="MyFirstWeb.FirstPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Registration</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            Employee Registration Page</h1>
        <table border="1" style="background-color: Aqua">
            <tr>
                <td>
                    <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Present Address:
                </td>
                <td>
                    <asp:TextBox ID="txtPressentAdd" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Perminant Address:
                </td>
                <td>
                    <asp:TextBox ID="txtPerminantAdd" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
              <tr>
                <td>
                    Gender:
                </td>
                <td>
                   <asp:RadioButton ID="rbtnMale" runat="server" Text="Male" />
                   <asp:RadioButton ID="rbtnFemale" runat="server" Text="Female" />
                   
                </td>
            </tr>
            
            <tr>
                <td>
                <asp:Button ID="btnAdd" runat="server" Text="Same As Present Address" OnClick="btnAdd_click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>

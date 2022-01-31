<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication5.WebForm2" UnobtrusiveValidationMode="none" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label">Enter Fruit Name</asp:Label>
            <input id="Text1" type="text" placeholder="Enter FruitName" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Text1" ErrorMessage="Data Required in Text1"></asp:RequiredFieldValidator>
            <br /><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Data Required" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
            <br /><asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
            <br /><asp:Label ID="Label2" runat="server" Text="List of Fruits">
                
                  </asp:Label><br /><asp:ListBox ID="ListBox1" runat="server" Width="150px"></asp:ListBox>
        </div>
      
    </form>
</body>
</html>

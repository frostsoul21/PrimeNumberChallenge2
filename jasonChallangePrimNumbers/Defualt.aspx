<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defualt.aspx.cs" Inherits="jasonChallangePrimNumbers.Defualt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            background-color: #CCFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Enter A Number:
            <asp:TextBox ID="numberTextBox" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="checkPrimeButton" runat="server" OnClick="checkPrimeButton_Click" Text="Check For Prime Numbers" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server" OnDataBinding="checkPrimeButton_Click"></asp:Label>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculatorWebForm.aspx.cs" Inherits="ChallengeSimpleCalculator.CalculatorWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Simple Calculator</h1>
            <br />
            First Value:&nbsp;
            <asp:TextBox ID="firstValue" runat="server"></asp:TextBox>
            <br />
            <br />
            Second Value:&nbsp;
            <asp:TextBox ID="secondValue" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="additionButton" runat="server" Text="+" OnClick="additionButton_Click" />
&nbsp;
            <asp:Button ID="subtractButton" runat="server" Text="-" OnClick="subtractButton_Click" />
&nbsp;
            <asp:Button ID="multiplyButton" runat="server" Text="*" OnClick="multiplyButton_Click" />
&nbsp;
            <asp:Button ID="divideButton" runat="server" Text="/" OnClick="divideButton_Click" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server" BackColor="#00CCFF" Font-Bold="True" ForeColor="Black"></asp:Label>
        </div>
    </form>
</body>
</html>

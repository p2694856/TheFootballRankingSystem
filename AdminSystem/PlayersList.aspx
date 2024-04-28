<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PlayersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <style>
        body {
    border: hidden;
    height : max-content;
    background-image: url('../images/StadiumMono.jpg');
    background-repeat: no-repeat;
    background-attachment: fixed;
    background-size: cover;
}

            img {
  display: block;
  margin-left: auto;
  margin-right: auto;
  width: 80%;
  height: 30%;
}

        label{
            color:white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 585px" >
            <div>
            <img src="../images/Logo.png" alt="Logo" />

            </div>
            <asp:ListBox ID="lstPlayersList" runat="server" Height="394px" Width="544px" ></asp:ListBox>
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            
            <br />
            <br />
            <asp:Label ID="Name" runat="server" Text="Enter a Name" ForeColor="White"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ForeColor="White"></asp:Label>
            <br />
            <br />
            <asp:Button ID="VoteToZero" runat="server" Text="Reset The Votes" BorderColor="Red" OnClick="VoteToZero_Click"  />
            <br />
        </div>
    </form>
</body>
</html>
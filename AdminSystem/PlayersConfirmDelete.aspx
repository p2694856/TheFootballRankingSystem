<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PlayersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

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
  height: 40%;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblDeleteThis" runat="server" Text="ARE YOU SURE YOU WANT TO DELETE THIS RECORD?"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" />
        </div>
    </form>
</body>
</html>

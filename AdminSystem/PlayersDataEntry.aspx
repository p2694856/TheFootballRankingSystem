<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PlayersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="lblPlayersID" runat="server" Text="PlayerID" Height="22px" Width="52px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPlayersID" runat="server" Height="25px" Width="168px" TextMode="Number" ></asp:TextBox>
            <asp:Button ID="ButtonFind" runat="server" OnClick="ButtonFind_Click" Text="Find" />
            <br />
            <asp:Label ID="lblName" runat="server" Text="Name" Width="52px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtName" runat="server" height="25px" width="168px"></asp:TextBox>
            <br />
            <asp:Label ID="lblColour" runat="server" Text="Team" Width="52px" Height="22px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTeam" runat="server" height="25px" width="168px"></asp:TextBox>
            <br />
            <asp:Label ID="lblNationality" runat="server" Text="Nationality" Width="52px" Height="22px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNationality" runat="server" height="25px" width="168px"></asp:TextBox><br class="Apple-interchange-newline">
            <asp:Label ID="lblPosition" runat="server" Text="Position" width="52px" height="22px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPosition" runat="server" height="25px" width="168px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <asp:Button ID="ButtonOK" runat="server" OnClick="ButtonOK_Click" Text="OK" />
            <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" UseSubmitBehavior="False" OnClick="ButtonCancel_Click" />
            <br />
            <br />
            <br />
            <br />
            <br />

        </div>
        <br />
    </form>
</body>
</html>


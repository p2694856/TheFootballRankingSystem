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
             <asp:Button ID="Logout" runat="server" OnClick="btnLogOut_Click" Text="Logout" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ForeColor="White"></asp:Label>
            <br />
            <br />
            <asp:Button ID="VoteToZero" runat="server" Text="Reset The Votes" BorderColor="Red" OnClick="VoteToZero_Click"  />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="3" CssClass="Table" DataSourceID="SqlDataSource1" Height="316px" HorizontalAlign="Center" Width="590px">
                <Columns>
                    <asp:TemplateField HeaderText="Rank" ItemStyle-ForeColor="White">
                        <ItemTemplate>
                <%# GetRank(Container.DataItemIndex + 1) %>
                        </ItemTemplate>
                        <ItemStyle CssClass="RankStyle" Font-Bold="True" Font-Size="X-Large" ForeColor="White" />
                    </asp:TemplateField>
                    <asp:BoundField DataField="Name" HeaderText="Name" ItemStyle-ForeColor="White" SortExpression="Name">
                    <ItemStyle Font-Size="Large" ForeColor="White" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Team" HeaderText="Team" ItemStyle-ForeColor="White" SortExpression="Team">
                    <ItemStyle Font-Size="Large" ForeColor="White" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Nationality" HeaderText="Nationality" ItemStyle-ForeColor="White" SortExpression="Nationality">
                    <ItemStyle Font-Size="Large" ForeColor="White" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Position" HeaderText="Position" ItemStyle-ForeColor="White" SortExpression="Position">
                    <ItemStyle Font-Size="Large" ForeColor="White" />
                    </asp:BoundField>
                    <asp:BoundField DataField="TotalPoints" HeaderText="TotalPoints" ItemStyle-ForeColor="White" SortExpression="TotalPoints">
                    <ItemStyle Font-Size="Large" ForeColor="White" />
                    </asp:BoundField>
                    
                </Columns>
                <HeaderStyle Font-Bold="True" Font-Size="Large" ForeColor="White" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:p2694856ConnectionString %>" SelectCommand="SELECT [Name], [Team], [Nationality], [Position], [TotalPoints] FROM [tblPlayers] ORDER BY [TotalPoints] DESC, [PlayerID], [Name]"></asp:SqlDataSource>
            <br />
        </div>
    </form>
</body>
</html>
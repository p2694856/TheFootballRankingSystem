<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="_1Viewer" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>


    h1 {text-align: center;
        font-family:'Times New Roman', Times, serif;
        font-family:'OCR A';
    }
  body {
  height : max-content;
  background-image: url('https://thesuperleague.com/assets/images/slider/bg/01_Hero8_Chelsea.jpg');
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
  .Table{
      border-color:transparent;
  }
   .btn5 {
   border-radius: 5px;
   border: 0;
   border-radius: 5px;
   box-shadow: 1px 2px 5px #666;
   background-color: #000000;
   color:whitesmoke;
   }
   .btn5:hover{
       transform: scale(1.1)
   }

   .btn5:active{
    transform: scale(0.9)
}

   .RankStyle{
       font-family:'OCR A';
   }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <img src="https://i.imgur.com/SphRQzL.png" alt="Logo" />
            <br />
            
            <h1 style="color:white;">
                Rankings can be found here
            </h1>
            <div>
                
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="3" DataSourceID="SqlDataSource1" CssClass="Table" HorizontalAlign="Center" OnRowCommand="Grid_RowCommand" Height="316px" Width="590px"  >
                    <Columns>
                        
                        <asp:TemplateField HeaderText="Rank" ItemStyle-ForeColor ="White">
                            <ItemTemplate>
                                <%# GetRank(Container.DataItemIndex + 1) %>
                            </ItemTemplate>
                            <ItemStyle ForeColor="White" Font-Size="X-Large" Font-Bold="True" CssClass="RankStyle"></ItemStyle>
                        </asp:TemplateField>
                        
                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" ItemStyle-ForeColor ="White" >
                        <ItemStyle ForeColor="White" Font-Size="Large"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="Team" HeaderText="Team" SortExpression="Team" ItemStyle-ForeColor ="White" >
                        <ItemStyle ForeColor="White" Font-Size="Large"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="Nationality" HeaderText="Nationality" SortExpression="Nationality" ItemStyle-ForeColor ="White">
                        <ItemStyle ForeColor="White" Font-Size="Large"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="Position" HeaderText="Position" SortExpression="Position" ItemStyle-ForeColor ="White" >
                        <ItemStyle ForeColor="White" Font-Size="Large"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="TotalPoints" HeaderText="TotalPoints" SortExpression="TotalPoints" ItemStyle-ForeColor ="White" >
                        <ItemStyle ForeColor="White" Font-Size="Large"></ItemStyle>
                        </asp:BoundField>
                        <asp:ButtonField ButtonType="Button" HeaderText="Vote" ShowHeader="True" Text="Vote" ControlStyle-CssClass="btn5" CommandName="VoteForPlayer" >
                        <ControlStyle CssClass="btn5"></ControlStyle>
                        </asp:ButtonField>
                    </Columns>
                    
                    
                    <HeaderStyle Font-Bold="True" ForeColor="White" Font-Size="Large"/>
                    
                    
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:p2694856ConnectionString %>" SelectCommand="SELECT [Name], [Team], [Nationality], [Position], [TotalPoints] FROM [tblPlayers] ORDER BY [TotalPoints] DESC, [PlayerID], [Name]"></asp:SqlDataSource>
                
            </div>
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            
            <br />
            

            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>

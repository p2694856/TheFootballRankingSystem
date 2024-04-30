<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="_1Viewer" %>


<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>


    h1 {text-align: center;
        font-family:'Times New Roman', Times, serif;
        font-family:'OCR A';
    }
    h2 {
        text-align: center;
        font-family:'Times New Roman', Times, serif;
        font-family:'OCR A';
        font-size:x-large;
    }
  body {
  height : max-content;
  background-image: url('../images/Stadium.jpg');
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
   .Chart{
       color:transparent;
       
   }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <img src="../images/Logo.png" alt="Logo" />
            <br />
            
            <h1 style="color:white;">
                Rankings can be found here
            </h1>
            <br />
            <h2 style="color:white;">
            Player Rankings
            </h2>
            <div>

               <asp:Label ID="lblUsername" runat="server" Text="" Font-Size="Large" Font-Bold="true" ForeColor="WhiteSmoke" CssClass="RankStyle" Style="margin-left:auto; display:block; margin-right: auto; text-align:center;"></asp:Label>
                <asp:Label ID="lblVotingPoint" runat="server" Text="" Font-Size="Large" Font-Bold="true" ForeColor="WhiteSmoke" CssClass="RankStyle" Style="margin-left:auto; display:block; margin-right: auto; text-align:center;"></asp:Label>
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
                    
                    
                    <HeaderStyle Font-Bold="True" ForeColor="White" Font-Size="Large" />
                    
                    
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:p2694856ConnectionString %>" SelectCommand="SELECT [Name], [Team], [Nationality], [Position], [TotalPoints] FROM [tblPlayers] ORDER BY [TotalPoints] DESC, [PlayerID], [Name]"></asp:SqlDataSource>
                
            </div>
            <asp:Label ID="lblResult" runat="server" Text="" Style="margin-left:auto; display:block; margin-right: auto; text-align:center; color:white; font-size:medium"></asp:Label>
            
            <br />
            <br />
            <h2 style="color:white;">
            Team Rankings
            </h2>
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:p2694856ConnectionStringGraph2 %>" OnSelecting="SqlDataSource2_Selecting" ProviderName="<%$ ConnectionStrings:p2694856ConnectionStringGraph2.ProviderName %>" SelectCommand="SELECT Team, SUM(TotalPoints) AS Combined_Points FROM tblPlayers GROUP BY Team ORDER BY Combined_Points DESC"></asp:SqlDataSource>
            <br />
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="3" DataSourceID="SqlDataSource2" CssClass="Table" OnRowCommand="Grid_RowCommand" Height="316px" Width="590px"  HorizontalAlign="Center">
                    <Columns>
                        <asp:TemplateField HeaderText="Rank" ItemStyle-ForeColor ="White">
                            <ItemTemplate>
                                <%# GetRank(Container.DataItemIndex + 1) %>
                            </ItemTemplate>
                            <ItemStyle ForeColor="White" Font-Size="X-Large" Font-Bold="True" CssClass="RankStyle" HorizontalAlign="Center" ></ItemStyle>
                        </asp:TemplateField>
                        
                        <asp:BoundField DataField="Team" HeaderText="Team" SortExpression="Team" ItemStyle-ForeColor ="White" >
                            <ItemStyle ForeColor="White" Font-Size="Large" HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="Combined_Points" HeaderText="Team Points" SortExpression="Combined_Points" ItemStyle-ForeColor ="White" ReadOnly="True"  >
                             <ItemStyle ForeColor="White" Font-Size="Large" HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
                    </Columns>
                    
                    
                    <HeaderStyle Font-Bold="True" ForeColor="White" Font-Size="Large" />
                    
                    
                </asp:GridView>
            <br />
            <br />
            <br />
            <h2 style="color:white;">
            Position Rankings
            </h2>
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:p2694856ConnectionStringPrime %>" SelectCommand="SELECT Position, SUM(TotalPoints) AS P_Points FROM tblPlayers GROUP BY Position ORDER BY P_Points DESC"></asp:SqlDataSource>
                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" CellPadding="3" DataSourceID="SqlDataSource3" CssClass="Table" OnRowCommand="Grid_RowCommand" Height="316px" Width="590px"  HorizontalAlign="Center">
                    <Columns>
                        <asp:TemplateField HeaderText="Rank" ItemStyle-ForeColor ="White">
                                <ItemTemplate>
                                    <%# GetRank(Container.DataItemIndex + 1) %>
                                </ItemTemplate>
                                <ItemStyle ForeColor="White" Font-Size="X-Large" Font-Bold="True" CssClass="RankStyle" HorizontalAlign="Center" ></ItemStyle>
                            </asp:TemplateField>
                        <asp:BoundField DataField="Position" HeaderText="Position" SortExpression="Position" ItemStyle-ForeColor ="White" >
                            <ItemStyle ForeColor="White" Font-Size="Large" HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="P_Points" HeaderText="P_Points" SortExpression="P_Points" ItemStyle-ForeColor ="White" ReadOnly="True"  >
                            <ItemStyle ForeColor="White" Font-Size="Large" HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
                    </Columns>
                    
                    
                    <HeaderStyle Font-Bold="True" ForeColor="White" Font-Size="Large" />
                    
                    
                </asp:GridView>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>

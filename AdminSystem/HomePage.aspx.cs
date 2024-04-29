using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         //creates instance of class
        clsRegister Register = new clsRegister();
        //get data from session
        Register = (clsRegister)Session["UserName"];
        //displays the data
        lblUsername = Response.Write(Register.Username);

        if (Register.Username  != null)
        {
            Register = (clsRegister)Session["VotingPoint"];
            Response.Write(Register.VotingPoint);
        }
        else
        {
            Response.Redirect("LoginPage.aspx");
        }
    }

    protected string GetRank(int index)
        {
            switch (index)
            {
                
                default:
                    return (index).ToString();
            }

            
    }
    protected void Grid_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        
            if (e.CommandName == "VoteForPlayer")
            {
            
            int rowIndex = Convert.ToInt32(e.CommandArgument);

            string playerName = GridView1.Rows[rowIndex].Cells[1].Text;

            clsPlayers Players = new clsPlayers();

            Players.Name = playerName;

            clsPlayersCollection PlayersList = new clsPlayersCollection();

            bool Exists = Players.FindName(playerName);

            if (Exists)
            {
                PlayersList.ThisPlayers = Players;
                PlayersList.AddVote();
                GridView1.DataBind();
                
            }
            else
            {
                lblResult.Text = "error";
            }
            



        }

            

    }







   
}
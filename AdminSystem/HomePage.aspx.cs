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

        

            if (Register != null)
            {   //displays the data
                
                lblUsername.Text = "Username: " + Register.Username;
                Register.Find(Register.Username);

                lblVotingPoint.Text = "Voting Point: " + Register.VotingPoint;
                
               
            } 
        
            else
            {
            //redirects login page if there are no cookies

                Response.Redirect("LoginPage.aspx");
            }
        
    }

        protected string GetRank(int index)
        {
        //Switch code obtained from stack overflow
            switch (index)
            {

                default:
                    return (index).ToString();
            }


        }
        protected void Grid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
        //load the cookies if retrieved
        clsRegister Register = new clsRegister();
        Register = (clsRegister)Session["UserName"];
        Register.Find(Register.Username);
        //logs current vote count
        int Vote = Register.VotingPoint;
        string Username = Register.Username;
        //if button is clicked 
        if (e.CommandName == "VoteForPlayer")
            {
            //if vote is more than 1
            if (Vote > 0)
            {
                //retrives the row

                int rowIndex = Convert.ToInt32(e.CommandArgument);

                string playerName = GridView1.Rows[rowIndex].Cells[1].Text;

                clsPlayers Players = new clsPlayers();
                // collects player name
                Players.Name = playerName;

                clsPlayersCollection PlayersList = new clsPlayersCollection();
                //finds the player
                bool Exists = Players.FindName(playerName);
                //if founds
                if (Exists)
                {
                    //makes the vote
                    clsRegisterCollection ThisVote = new clsRegisterCollection();
                    PlayersList.ThisPlayers = Players;
                    PlayersList.AddVote();
                    ThisVote.MakeVote(Username);
                    //updates the tables and voting point quantity
                    lblVotingPoint.Text = "Voting Point: " + Register.VotingPoint.ToString();

                    GridView1.DataBind();
                    lblVotingPoint.DataBind();
                    GridView2.DataBind();
                    GridView3.DataBind();


                }
                else
                {
                    //validation
                    lblResult.Text = "error";
                }

            }
            else
            {
                //validation
                lblResult.Text = "You have Ran Out of Voting Points please wait till they are refreshed";
            }


            }



        }



    protected void btnLogout_Click(object sender, EventArgs e)
    {
        //redirects to main menu
        Session["UserName"] = null;
        Response.Redirect("TeamMainMenu.aspx");

    }





    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }

    protected void SqlDataSource2_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }

    
}
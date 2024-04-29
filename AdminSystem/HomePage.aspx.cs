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

        clsRegister Register = new clsRegister();
        Register = (clsRegister)Session["UserName"];
        Register.Find(Register.Username);
        int Vote = Register.VotingPoint;
        string Username = Register.Username;
        if (e.CommandName == "VoteForPlayer")
            {

            if (Vote > 0)
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);

                string playerName = GridView1.Rows[rowIndex].Cells[1].Text;

                clsPlayers Players = new clsPlayers();

                Players.Name = playerName;

                clsPlayersCollection PlayersList = new clsPlayersCollection();

                bool Exists = Players.FindName(playerName);

                if (Exists)
                {
                    clsRegisterCollection ThisVote = new clsRegisterCollection();
                    PlayersList.ThisPlayers = Players;
                    PlayersList.AddVote();
                    
                    ThisVote.MakeVote(Username);
                    lblVotingPoint.Text = "Voting Point: " + Register.VotingPoint;
                    GridView1.DataBind();

                }
                else
                {
                    lblResult.Text = "error";
                }

            }
            else
            {
                lblResult.Text = "You have Ran Out of Voting Points please wait till they are refreshed";
            }


            }



        }




    


   
}
using ClassLibrary;
using System;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 PlayerID;
    protected void Page_Load(object sender, EventArgs e)
    {

        PlayerID = Convert.ToInt32(Session["PlayerID"]);
        if (IsPostBack == false)
        {
            if (PlayerID != -1)
            {
                DisplayPlayers();
            }
        }

    }

    private void DisplayPlayers()
    {
        clsPlayersCollection PlayersBook = new clsPlayersCollection();

        PlayersBook.ThisPlayers.Find(PlayerID);
        txtPlayersID.Text = Convert.ToString(PlayersBook.ThisPlayers.PlayerID);
        txtName.Text = PlayersBook.ThisPlayers.Name;
        txtTeam.Text = PlayersBook.ThisPlayers.Team;
        txtNationality.Text = PlayersBook.ThisPlayers.Nationality;
        txtPosition.Text = PlayersBook.ThisPlayers.Position;

    }

    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        clsPlayers Players = new clsPlayers();


        string Name = txtName.Text;
        string Team = txtTeam.Text;
        string Position = txtPosition.Text;
        string Nationality = txtNationality.Text;

        string Error = "";

        Error = Players.Valid(Name, Team, Position, Nationality);

        if (Error == "")
        {
            //creates an instance

            //captures the data
            Players.PlayerID = PlayerID;
            Players.Name = Name;
            Players.Team = Team;
            Players.Nationality = Nationality;
            Players.Position = Position;



            clsPlayersCollection PlayersList = new clsPlayersCollection();
            if (PlayerID == -1)
            {
                PlayersList.ThisPlayers = Players;

                PlayersList.Add();
            }
            else
            {
                PlayersList.ThisPlayers.Find(PlayerID);

                PlayersList.ThisPlayers = Players;

                PlayersList.Update();
            }


            //navigate the viewers page
            Response.Redirect("PlayersList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }


    }

    protected void ButtonFind_Click(object sender, EventArgs e)
    {
        //creates an instance
        clsPlayers Players = new clsPlayers();
        //store primary key
        Int32 PlayerID;
        //result of find operation
        Boolean Found = false;
        //get primary key
        PlayerID = Convert.ToInt32(txtPlayersID.Text);
        //finding record
        Found = Players.Find(PlayerID);
        //if Found
        if (Found == true)
        {
            txtName.Text = Players.Name;
            txtTeam.Text = Players.Team;
            txtNationality.Text = Players.Nationality;
            txtPosition.Text = Players.Position;

        }
        else
        {
            txtName.Text = "Player Nonexistant";
            txtTeam.Text = "";
            txtNationality.Text = "";
            txtPosition.Text = "";
        }


    }

    protected void ButtonCancel_Click(object sender, EventArgs e)
    {
        txtName.Text = "";
        txtTeam.Text = "";
        txtNationality.Text = "";
        txtPosition.Text = "";

        //navigate the viewers page
        Response.Redirect("PlayersList.aspx");

    }
}
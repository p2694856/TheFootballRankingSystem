using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    Int32 PlayerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        PlayerID = Convert.ToInt32(Session["PlayerID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsPlayersCollection Players = new clsPlayersCollection();

        Players.ThisPlayers.Find(PlayerID);

        Players.Delete();

        Response.Redirect("PlayersList.aspx");
    }


    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("PlayersList.aspx");
    }
}
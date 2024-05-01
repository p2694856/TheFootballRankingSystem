using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayPlayers();
        }

        if (Session["Admin"] == null)
        {
            Response.Redirect("TeamMainMenu.aspx");
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
    void DisplayPlayers()
    {
        clsPlayersCollection Players = new clsPlayersCollection();

        lstPlayersList.DataSource = Players.PlayersList;
        lstPlayersList.DataValueField = "PlayerID";
        lstPlayersList.DataTextField = "Name";
        lstPlayersList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["PlayerID"] = -1;

        Response.Redirect("PlayersDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 PlayerID;

        if (lstPlayersList.SelectedIndex != -1)
        {
            PlayerID = Convert.ToInt32(lstPlayersList.SelectedValue);

            Session["PlayerID"] = PlayerID;

            Response.Redirect("PlayersDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from this list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        {
            Int32 PlayerID;

            if (lstPlayersList.SelectedIndex != -1)
            {
                PlayerID = Convert.ToInt32(lstPlayersList.SelectedValue);

                Session["PlayerID"] = PlayerID;

                Response.Redirect("PlayersConfirmDelete.aspx");
            }
            else
            {
                lblError.Text = "Please select a record to edit from this list";
            }
        }

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsPlayersCollection Players = new clsPlayersCollection();
        Players.ReportByName(txtFilter.Text);
        lstPlayersList.DataSource = Players.PlayersList;
        lstPlayersList.DataValueField = "PlayerID";
        lstPlayersList.DataTextField = "Name";
        lstPlayersList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsPlayersCollection Players = new clsPlayersCollection();
        Players.ReportByName("");
        txtFilter.Text = "";
        lstPlayersList.DataSource = Players.PlayersList;
        lstPlayersList.DataValueField = "PlayerID";
        lstPlayersList.DataTextField = "Name";
        lstPlayersList.DataBind();
    }

    protected void VoteToZero_Click(object sender, EventArgs e)
    {
        clsPlayersCollection PlayersList = new clsPlayersCollection();

        PlayersList.ToZero();
    }

    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        Session["Admin"] = null;
        Response.Redirect("TeamMainMenu.aspx");
    }
}
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //creates instance of class
        clsPlayers Players = new clsPlayers();
        //get data from session
        Players = (clsPlayers)Session["PlayerID"];
        //displays the data
        Response.Write(Players.Name);
        //get data from session
        Players = (clsPlayers)Session["PlayerID"];
        //displays the data
        Response.Write(Players.Team);
        //get data from session
        Players = (clsPlayers)Session["PlayerID"];
        //displays the data
        Response.Write(Players.Nationality);
        //get data from session
        Players = (clsPlayers)Session["PlayerID"];
        //displays the data
        Response.Write(Players.PlayerID);
        //get data from session
        Players = (clsPlayers)Session["PlayerID"];
        //displays the data
        Response.Write(Players.Position);
        
       

    }
}

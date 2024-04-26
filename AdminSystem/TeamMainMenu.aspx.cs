using System;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("LoginPage.aspx");
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {

    }
}
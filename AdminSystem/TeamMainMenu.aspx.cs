using System;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //Redirects to login page
        Response.Redirect("LoginPage.aspx");
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        //Redirect to Register page
        Response.Redirect("RegisterPage.aspx");
    }

    protected void btnAdmin_Click(object sender, EventArgs e)
    {
        //Redirects to Admin Login page
        Response.Redirect("AdminLogin.aspx");
    }
}
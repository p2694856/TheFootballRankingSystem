using ClassLibrary;
using System;
using System.Data.SqlClient;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsRegister Register = new clsRegister();
        //collects string
        string FirstName = txtFName.Text;
        string LastName = txtLName.Text;
        string Password = txtPassword.Text;
        string Error = "";
        //validation
        Error = Register.ValidAdmin(FirstName, LastName, Password);

        if (Error == "")
        {

            Register.FirstName = FirstName;
            Register.FirstName = LastName;
            clsRegisterCollection RegisterList = new clsRegisterCollection();

            bool Exists = RegisterList.ThisRegister.FindAdmin(FirstName,LastName);

            if (Exists == true)
            {
                //encryption
                string EPassword = "";
                clsRegisterCollection RegisterBook = new clsRegisterCollection();
                RegisterBook.ThisRegister.FindAdmin(FirstName,LastName);
                EPassword = RegisterBook.ThisRegister.Password;
                Encryptor Encryptor = new Encryptor();
                string DecryptedPassword = Encryptor.Decrypt(EPassword, Encryptor.keyvalue);
                if (Password == DecryptedPassword)
                {
                    //cookies
                    Session["Admin"] = 1;
                    //redirects to player list page
                    Response.Redirect("PlayersList.aspx");
                }
                else
                {
                    //validation
                    lblError.Text = "Password Incorrect";
                }
            }
            else
            {
                //validation
                lblError.Text = "First Name and Last Name do not exist";
            }
        }
        else
        {
            //validation
            lblError.Text = Error;
        }
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        //redirect to admin register
        Response.Redirect("AdminRegister.aspx");
    }
}

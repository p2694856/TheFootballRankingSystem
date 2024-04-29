using ASP;
using ClassLibrary;
using Microsoft.SqlServer.Server;
using Microsoft.Win32;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;

public partial class _1Viewer : System.Web.UI.Page
{



    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsRegister Register = new clsRegister();  

        string Username = txtUsername.Text;
        string Password = txtPassword.Text;
        string Error = "";

        Error = Register.Valid(Username, Password);

        if (Error == "")
        {
            
            Register.Username = Username;
            clsRegisterCollection RegisterList = new clsRegisterCollection();

            bool Exists = RegisterList.ThisRegister.Find(Username);
            
            if (Exists == true) 
            {
                string EPassword = "";
                clsRegisterCollection RegisterBook = new clsRegisterCollection();
                RegisterBook.ThisRegister.Find(Username);
                EPassword = RegisterBook.ThisRegister.Password;
                Encryptor Encryptor = new Encryptor();
                string DecryptedPassword = Encryptor.Decrypt(EPassword, Encryptor.keyvalue);
                if (Password == DecryptedPassword)
                {
                    Session["UserName"] = Register;
                    
                    Response.Redirect("HomePage.aspx");


                }
                else
                {
                    lblError.Text = "Password Incorrect";
                }
            }
            else
            {
                lblError.Text = "Username does not exist";
            }
        }
        else
        {
            lblError.Text = Error;
        }
    }
}
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //redirect admin login
        Response.Redirect("AdminLogin.aspx");
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        clsRegister Register = new clsRegister();
        //collects the strng
        
        string FirstName = txtFName.Text;
        string LastName = txtFName.Text;
        string Password = txtPassword.Text;
        string ConfirmPassword = txtCPassword.Text;

        int AdminCode = 0;
        // if code is integer check
        bool AdminCodeIsInt = int.TryParse(txtAdminCode.Text, out AdminCode);
        //validation
        string Error = "";

       
        Error = Register.ValidAdmin(FirstName, LastName, Password);
        if (Password == ConfirmPassword)
        {
            if (AdminCodeIsInt)
            {
                if (Register.Match(AdminCode) == true)
                {

                    if (Error == "")
                    {
                        //creates an instance

                        //captures the data


                        Register.FirstName = FirstName;
                        Register.LastName = LastName;




                        clsRegisterCollection RegisterList = new clsRegisterCollection();
                        //checks if username exsists
                        bool Exists = RegisterList.ThisRegister.FindAdmin(FirstName, LastName);



                        if (Exists == true)
                        {
                            //validation
                            lblError.Text = "Name already exists please try adding a number to you name";
                        }
                        else
                        {
                            //encrypts data
                            Encryptor Encryptor = new Encryptor();
                            Register.Password = Encryptor.Encrypt(Password, Encryptor.keyvalue);
                            RegisterList.ThisRegister = Register;
                            RegisterList.AddAdmin();
                            //navigate the player list page

                            Session["Admin"] = 1;
                            Response.Redirect("PlayersList.aspx");

                        }

                        //validation
                    }
                    else
                    {
                        lblError.Text = Error;
                    }

                }
                else
                {
                    lblError.Text = "AdminCode does not Match please try again";
                }
            }
            else
            {
                lblError.Text = "AdminCode must be a Number";
            }

        }
        else
        {
            lblError.Text = "Password and Confirm Password do not match please check and try again";
        }

    }
}


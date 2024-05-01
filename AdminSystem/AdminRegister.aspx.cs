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

        Response.Redirect("AdminLogin.aspx");
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        clsRegister Register = new clsRegister();
        
        string FirstName = txtFName.Text;
        string LastName = txtFName.Text;
        string Password = txtPassword.Text;
        string ConfirmPassword = txtCPassword.Text;

        int AdminCode = 0;

        bool AdminCodeIsInt = int.TryParse(txtAdminCode.Text, out AdminCode);

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
                            lblError.Text = "Name already exists please try adding a number to you name";
                        }
                        else
                        {
                            Encryptor Encryptor = new Encryptor();
                            Register.Password = Encryptor.Encrypt(Password, Encryptor.keyvalue);
                            RegisterList.ThisRegister = Register;
                            RegisterList.AddAdmin();
                            //navigate the viewers page

                            Session["Admin"] = 1;
                            Response.Redirect("PlayersList.aspx");

                        }


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


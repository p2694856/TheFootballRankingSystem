using System;
using System.Activities.Statements;
using System.Security.Cryptography;
using ClassLibrary;
public partial class _1_List : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        clsRegister Register = new clsRegister();

        //collects strings
        string Username = txtUsername.Text;
        string Password = txtPassword.Text;
        string ConfirmPassword = txtCPassword.Text;
        


        string Error = "";
        //validation
        Error = Register.Valid(Username, Password);
        if (Password == ConfirmPassword)
        {
            if (Error == "")
            {
                //creates an instance
                
                //captures the data
               

                Register.Username = Username;
                

                

                clsRegisterCollection RegisterList = new clsRegisterCollection();
                //checks if username exsists
                bool Exists = RegisterList.ThisRegister.Find(Username);



                if (Exists == true)
                {
                    lblError.Text = "Username already exists please try another one";
                }
                else
                {
                    //encrypts password
                    Encryptor Encryptor = new Encryptor();
                    Register.Password = Encryptor.Encrypt(Password, Encryptor.keyvalue);
                    RegisterList.ThisRegister = Register;
                    RegisterList.Add();
                    Session["UserName"] = Register;
                    //navigate the viewers page
                    Response.Redirect("HomePage.aspx");
                }
                
                
            }
            else
            {
                //validation
                lblError.Text = Error;
            }

        }
        else
        {
            //validation
            lblError.Text = "Password and Confirm Password do not match please check and try again";
        }

    }
}

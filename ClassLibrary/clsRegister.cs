using System;
using System.IO;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class clsRegister
    {

        private string mUsername;
        public string Username
        {
            get
            {
                //out of property 
                return mUsername;
            }
            set
            {
                //in property
                mUsername = value;

            }
        }
        private string mPassword;

        public string Password
        {
            get
            {
                //out of property 
                return mPassword;
            }
            set
            {
                //in property
                mPassword = value;

            }
        }

        private Int32 mVotingPoint;
        public Int32 VotingPoint
        {
            get
            {
                //out of property 
                return mVotingPoint;
            }
            set
            {
                //in property
                mVotingPoint = value;

            }

        }

        public bool Find(string Username)
        {
            //creates Instance
            clsDataConnection DB = new clsDataConnection();
            //adds parameter
            DB.AddParameter("@Username", Username);
            //execute stored procedure
            DB.Execute("sproc_tblUserLogin_FilterByUsername");
            if (DB.Count == 1)
            {
                //sets private data members to test value
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                //Always True
                return true;
            }
            else
            {
                return false;
            }
        }


        public string Valid(string username, string password)
        {
            String Error = "";
            //if Value is blank
            if (username.Length == 0)
            {
                Error = Error + "The Username should not be blank : ";
            }
            if (username.Length > 10)
            {
                Error = Error + "The Username should not be over 10 characters : ";
            }
            if (password.Length == 0)
            {
                Error = Error + "The Password should not be blank : ";
            }
            if (password.Length > 20)
            {
                Error = Error + "The Password should not be over 20 characters : ";
            }
            //if (votingPoint.Length == 0)
            //{
           //     Error = Error + "The Voting Point should not be blank : ";
            //}
            //if (votingPoint.Length > 20)
            //{
             //   Error = Error + "The Voting Point should not be over 20 characters : ";
            //}

            //return any error messege
            return Error;
        }
    }
}

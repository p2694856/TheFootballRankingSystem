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


        private string mFirstName;
        public string FirstName
        {
            get
            {
                //out of property 
                return mFirstName;
            }
            set
            {
                //in property
                mFirstName = value;

            }
        }


        private string mLastName;
        public string LastName
        {
            get
            {
                //out of property 
                return mLastName;
            }
            set
            {
                //in property
                mLastName = value;

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

        private string mAdminCode;
        public string AdminCode
        {
            get
            {
                //out of property 
                return mAdminCode;
            }
            set
            {
                //in property
                mAdminCode = value;

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
                mVotingPoint = Convert.ToInt32(DB.DataTable.Rows[0]["VotingPoint"]);
                //Always True
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FindAdmin(string FirstName,string LastName)
        {
            //creates Instance
            clsDataConnection DB = new clsDataConnection();
            //adds parameter
            DB.AddParameter("@FirstName", FirstName);
            DB.AddParameter("@LastName", LastName);
            //execute stored procedure
            DB.Execute("sproc_tblAdminLogin_FilterByName");
            if (DB.Count == 1)
            {
                //sets private data members to test value
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                //Always True
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool Match(int AdminCode)
        {
            //creates Instance
            clsDataConnection DB = new clsDataConnection();
            //adds parameter
            DB.AddParameter("@AdminCode", AdminCode);
            //execute stored procedure
            DB.Execute("sproc_tblAdminCode_MatchByAdminCode");
            if (DB.Count == 1)
            {
                //sets private data members to test value
                mAdminCode = Convert.ToString(DB.DataTable.Rows[0]["AdminCode"]);
                
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

            //return any error messege
            return Error;
        }

        public string ValidAdmin(string firstname, string lastname, string password)
        {
            String Error = "";
            //if Value is blank
            if (firstname.Length == 0)
            {
                Error = Error + "The First Name should not be blank : ";
            }
            if (firstname.Length > 15)
            {
                Error = Error + "The First Name should not be over 10 characters : ";
            }
            if (lastname.Length == 0)
            {
                Error = Error + "The Last Name should not be blank : ";
            }
            if (lastname.Length > 15)
            {
                Error = Error + "The Last Name should not be over 10 characters : ";
            }
            if (password.Length == 0)
            {
                Error = Error + "The Password should not be blank : ";
            }
            if (password.Length > 20)
            {
                Error = Error + "The Password should not be over 20 characters : ";
            }
            

            //return any error messege
            return Error;
        }
    }
}

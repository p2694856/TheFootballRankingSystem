using System;

namespace ClassLibrary
{
    public class clsPlayers
    {


        private string mName;
        public string Name
        {
            get
            {
                //out of property 
                return mName;
            }
            set
            {
                //in property
                mName = value;

            }
        }
        private string mTeam;

        public string Team
        {
            get
            {
                //out of property 
                return mTeam;
            }
            set
            {
                //in property
                mTeam = value;

            }
        }
        private string mNationality;
        public string Nationality
        {
            get
            {
                //out of property 
                return mNationality;
            }
            set
            {
                //in property
                mNationality = value;

            }
        }
        private string mPosition;
        public string Position
        {
            get
            {
                //out of property 
                return mPosition;
            }
            set
            {
                //in property
                mPosition = value;

            }
        }
        private Int32 mPlayersID;
        public Int32 PlayerID
        {
            get
            {
                //out of property 
                return mPlayersID;
            }
            set
            {
                //in property
                mPlayersID = value;

            }

        }

        public bool Find(int PlayerID)
        {
            //creates Instance
            clsDataConnection DB = new clsDataConnection();
            //adds parameter
            DB.AddParameter("@PlayerID", PlayerID);
            //execute stored procedure
            DB.Execute("sproc_tblPlayers_FilterByPlayerID");
            if (DB.Count == 1)
            {
                //sets private data members to test value
                mPlayersID = Convert.ToInt32(DB.DataTable.Rows[0]["PlayerID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mTeam = Convert.ToString(DB.DataTable.Rows[0]["Team"]);
                mNationality = Convert.ToString(DB.DataTable.Rows[0]["Nationality"]);
                mPosition = Convert.ToString(DB.DataTable.Rows[0]["Position"]);
                
                //Always True
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool FindName(string Name)
        {
            //creates Instance
            clsDataConnection DB = new clsDataConnection();
            //adds parameter
            DB.AddParameter("Name", Name);
            //execute stored procedure
            DB.Execute("sproc_tblPlayers_FilterByName");
            if (DB.Count == 1)
            {
                //sets private data members to test value
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);

                //Always True
                return true;
            }
            else
            {
                return false;
            }




        }

        public string Valid(string name, string team, string nationality, string position)
        {
            String Error = "";
            //if Value is blank
            if (name.Length == 0)
            {
                Error = Error + "The Name should not be blank : ";
            }
            if (name.Length > 20)
            {
                Error = Error + "The Name should not be over 20 characters : ";
            }
            if (team.Length == 0)
            {
                Error = Error + "The team should not be blank : ";
            }
            if (team.Length > 20)
            {
                Error = Error + "The team should not be over 20 characters : ";
            }
            if (nationality.Length == 0)
            {
                Error = Error + "The nationality should not be blank : ";
            }
            if (nationality.Length > 20)
            {
                Error = Error + "The nationality should not be over 20 characters : ";
            }
            if (position.Length == 0)
            {
                Error = Error + "The position should not be blank : ";
            }
            if (position.Length > 20)
            {
                Error = Error + "The position should not be over 20 characters : ";
            }

            //return any error messege
            return Error;
        }




    }
}
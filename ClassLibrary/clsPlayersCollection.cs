using System;
using System.Collections.Generic;



namespace ClassLibrary
{
    public class clsPlayersCollection
    {


        List<clsPlayers> mPlayersList = new List<clsPlayers>();
        clsPlayers mThisPlayers = new clsPlayers();


        public List<clsPlayers> PlayersList
        {
            get
            {
                return mPlayersList;
            }
            set
            {
                mPlayersList = value;
            }
        }
        public int Count
        {
            get
            {
                return mPlayersList.Count;
            }
            set
            {

            }
        }
        public clsPlayersCollection()
        {




            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblPlayers_SelectAll");
            PopulateArray(DB);


        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            mPlayersList = new List<clsPlayers>();
            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsPlayers Players = new clsPlayers();

                Players.PlayerID = Convert.ToInt32(DB.DataTable.Rows[Index]["PlayerID"]);
                Players.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                Players.Team = Convert.ToString(DB.DataTable.Rows[Index]["Team"]);
                Players.Nationality = Convert.ToString(DB.DataTable.Rows[Index]["Nationality"]);
                Players.Position = Convert.ToString(DB.DataTable.Rows[Index]["Position"]);


                mPlayersList.Add(Players);
                Index++;

            }
        }

        public clsPlayers ThisPlayers
        {
            get
            {
                return mThisPlayers;
            }


            set
            {
                mThisPlayers = value;
            }
        }

        public int ToZero()
        {
            clsDataConnection DB = new clsDataConnection();
            return DB.Execute("sproc_tblPlayers_ZeroVotes");
        }


        public int AddVote()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("Name", mThisPlayers.Name);

            return DB.Execute("sproc_tblPlayers_VotesAdded");
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();


            DB.AddParameter("Name", mThisPlayers.Name);
            DB.AddParameter("Team", mThisPlayers.Team);
            DB.AddParameter("Nationality", mThisPlayers.Nationality);
            DB.AddParameter("Position", mThisPlayers.Position);
            return DB.Execute("sproc_tblPlayers_Insert");
        }

        public int Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("PlayerID", mThisPlayers.PlayerID);
            DB.AddParameter("Name", mThisPlayers.Name);
            DB.AddParameter("Team", mThisPlayers.Team);
            DB.AddParameter("Nationality", mThisPlayers.Nationality);
            DB.AddParameter("Position", mThisPlayers.Position);
            return DB.Execute("sproc_tblPlayers_Update");
        }

        public int Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@PlayerID", mThisPlayers.PlayerID);

            return DB.Execute("sproc_tblPlayers_Delete");
        }

        public void ReportByName(string Name)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Name", Name);

            DB.Execute("sproc_tblPlayers_FilterByName");

            PopulateArray(DB);
        }


    }
}
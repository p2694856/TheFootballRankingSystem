using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsRegisterCollection
    {
        List<clsRegister> mRegisterList = new List<clsRegister>();
        clsRegister mThisRegister = new clsRegister();


        public List<clsRegister> RegisterList
        {
            get
            {
                return mRegisterList;
            }
            set
            {
                mRegisterList = value;
            }
        }
        public int Count
        {
            get
            {
                return mRegisterList.Count;
            }
            set
            {

            }
        }


        public clsRegister ThisRegister
        {
            get
            {
                return mThisRegister;
            }


            set
            {
                mThisRegister = value;
            }
        }


        public int MakeVote(string Username)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Username", Username);
            return DB.Execute("sproc_tblUserLogin_VoteMade");
        }


       

            public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            
            DB.AddParameter("Username", mThisRegister.Username);
            DB.AddParameter("Password", mThisRegister.Password);
            return DB.Execute("sproc_tblUserLogin_Insert");
        }

        public int AddAdmin()
        {
            clsDataConnection DB = new clsDataConnection();


            DB.AddParameter("FirstName", mThisRegister.FirstName);
            DB.AddParameter("LastName", mThisRegister.LastName);
            DB.AddParameter("Password", mThisRegister.Password);
            return DB.Execute("sproc_tblAdminLogin_Insert");
        }
    }
}

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


        public clsRegisterCollection()
        {




            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblUserLogin_SelectAll");
            PopulateArray(DB);


        }


        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            mRegisterList = new List<clsRegister>();
            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsRegister Register = new clsRegister();


                Register.Username = Convert.ToString(DB.DataTable.Rows[Index]["Username"]);
                Register.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);



                mRegisterList.Add(Register);
                Index++;

            }

        }

            public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            
            DB.AddParameter("Username", mThisRegister.Username);
            DB.AddParameter("Password", mThisRegister.Password);
            return DB.Execute("sproc_tblUserLogin_Insert");
        }
    }
}

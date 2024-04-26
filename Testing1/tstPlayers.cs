using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing4
{
    [TestClass]
    public class UnitTest1
    {
        //test data
        string Name = "Kevin De Bruyne";
        string Team = "Manchester City";
        string Nationality = "Belgium";
        string Position = "Midfielder";



        [TestMethod]
        public void TestMethod1()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //test that it exists
            Assert.IsNotNull(Players);
        }

        [TestMethod]

        public void TestPlayerID()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //creates test data

            int TestData = 3;

            //assigns data
            Players.PlayerID = TestData;
            //test that it exists
            Assert.AreEqual(Players.PlayerID, TestData);
        }
        [TestMethod]
        public void TestName()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //creates test data
            String TestData = "Kevin De Bruyne";
            //assigns data
            Players.Name = TestData;
            //test that it exists
            Assert.AreEqual(Players.Name, TestData);
        }
        [TestMethod]
        public void TestTeam()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //creates test data
            String TestData = "Manchester City";
            //assigns data
            Players.Team = TestData;
            //test that it exists
            Assert.AreEqual(Players.Team, TestData);
        }
        [TestMethod]
        public void TestPosition()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //creates test data
            String TestData = "Midfielder";
            //assigns data
            Players.Position = TestData;
            //test that it exists
            Assert.AreEqual(Players.Position, TestData);
        }
        [TestMethod]
        public void TestNationality()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //creates test data
            String TestData = "Belgium";
            //assigns data
            Players.Nationality = TestData;
            //test that it exists
            Assert.AreEqual(Players.Nationality, TestData);
        }
        [TestMethod]
        public void TestFindMethod()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //stores result of validation
            Boolean Found = false;
            //creates test data
            Int32 PlayerID = 1;
            //invokes instance
            Found = Players.Find(PlayerID);
            //test that it exists
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestFindLogMethod()
        {
            //create class instance
            clsRegister Register = new clsRegister();
            //stores result of validation
            Boolean Found = false;
            //creates test data
            string Username = "axel4410";
            //invokes instance
            Found = Register.Find(Username);
            //test that it exists
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestPlayersFound()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //stores result of validation
            Boolean Found = false;
            //stores result of validation
            Boolean OK = true;
            //creates test data
            Int32 PlayerID = 1;
            //invokes instance
            Found = Players.Find(PlayerID);
            //checks address
            if (Players.PlayerID != 1)
            {
                OK = false;
            }
            //test that it exists
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestNameFound()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //stores result of validation
            Boolean Found = false;
            //stores result of validation
            Boolean OK = true;
            //creates test data
            Int32 PlayerID = 1;
            //invokes instance
            Found = Players.Find(PlayerID);
            //checks address
            if (Players.Name != "Kevin De Bruyne\r\n")
            {
                OK = false;
            }
            //test that it exists
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTeamFound()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //stores result of validation
            Boolean Found = false;
            //stores result of validation
            Boolean OK = true;
            //creates test data
            Int32 PlayerID = 1;
            //invokes instance
            Found = Players.Find(PlayerID);
            //checks address
            if (Players.Team != "Manchester City")
            {
                OK = false;
            }
            //test that it exists
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPositionFound()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //stores result of validation
            Boolean Found = false;
            //stores result of validation
            Boolean OK = true;
            //creates test data
            Int32 PlayerID = 1;
            //invokes instance
            Found = Players.Find(PlayerID);
            //checks address
            if (Players.Position != "Midfielder")
            {
                OK = false;
            }
            //test that it exists
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestNationalityFound()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //stores result of validation
            Boolean Found = false;
            //stores result of validation
            Boolean OK = true;
            //creates test data
            Int32 PlayerID = 1;
            //invokes instance
            Found = Players.Find(PlayerID);
            //checks address
            if (Players.Nationality != "Belgium")
            {
                OK = false;
            }
            //test that it exists
            Assert.IsTrue(OK);
        }




        [TestMethod]
        public void TestValidation()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestNameMinLessOne()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Name = "";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestNameMin()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Name = "a";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestNameMinPlusOne()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Name = "aa";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestNameMaxLessOne()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Name = "aaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestNameMax()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Name = "aaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestNameMid()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Name = "aaaaa";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestNameMaxPlusOne()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Name = "aaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestNameExtremeMax()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Name = "";
            Name = Name.PadRight(500, 'a');
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void TestTeamMinLessOne()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Team = "";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestTeamMin()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Team = "a";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestTeamMinPlusOne()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Team = "aa";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestTeamMaxLessOne()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Team = "aaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestTeamMax()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Team = "aaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestTeamMid()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Team = "aaaaa";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestTeamMaxPlusOne()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Team = "aaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestTeamExtremeMax()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Team = "";
            Team = Team.PadRight(500, 'a');
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void TestPositionMinLessOne()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Position = "";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestPositionMin()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Position = "a";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestPositionMinPlusOne()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Position = "aa";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestPositionMaxLessOne()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Position = "aaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestPositionMax()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Position = "aaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestPositionMid()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Position = "aaaaa";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestPositionMaxPlusOne()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Position = "aaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestPositionExtremeMax()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Position = "";
            Position = Position.PadRight(500, 'a');
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void TestNationalityMinLessOne()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Nationality = "";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestNationalityMin()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Nationality = "a";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestNationalityMinPlusOne()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Nationality = "aa";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestNationalityMaxLessOne()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Nationality = "aaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestNationalityMax()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Nationality = "aaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestNationalityMid()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Nationality = "aaaaa";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestNationalityMaxPlusOne()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Nationality = "aaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestNationalityExtremeMax()
        {
            //create class instance
            clsPlayers Players = new clsPlayers();
            //Stores error messege
            String Error = "";
            //test data for method
            string Nationality = "";
            Nationality = Nationality.PadRight(500, 'a');
            //invoke the method
            Error = Players.Valid(Name, Team, Position, Nationality);
            //test that it exists
            Assert.AreNotEqual(Error, "");
        }







    }


}
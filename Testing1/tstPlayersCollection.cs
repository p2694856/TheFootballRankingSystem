using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstPlayersCollection
    {


        [TestMethod]
        public void InstanceOK()
        {
            clsPlayersCollection AllPlayers = new clsPlayersCollection();

            Assert.IsNotNull(AllPlayers);
        }


        [TestMethod]
        public void PlayersLineOK()
        {
            clsPlayersCollection AllPlayers = new clsPlayersCollection();

            List<clsPlayers> TestList = new List<clsPlayers>();

            clsPlayers TestItem = new clsPlayers();



            TestItem.PlayerID = 6;
            TestItem.Name = "Mohamed Salah";
            TestItem.Team = "Liverpool";
            TestItem.Nationality = "Egypt";
            TestItem.Position = "Attacker";

            TestList.Add(TestItem);

            AllPlayers.PlayersList = TestList;

            Assert.AreEqual(AllPlayers.PlayersList, TestList);
        }
        [TestMethod]
        public void ThisPlayersPropertyOK()
        {
            clsPlayersCollection AllPlayers = new clsPlayersCollection();

            clsPlayers TestPlayers = new clsPlayers();



            TestPlayers.PlayerID = 6;
            TestPlayers.Name = "Mohamed Salah";
            TestPlayers.Team = "Liverpool";
            TestPlayers.Nationality = "Egypt";
            TestPlayers.Position = "Attacker";




            AllPlayers.ThisPlayers = TestPlayers;

            Assert.AreEqual(AllPlayers.ThisPlayers, TestPlayers);
        }

        [TestMethod]
        public void PlayersLineAndCountOK()
        {
            clsPlayersCollection AllPlayers = new clsPlayersCollection();

            List<clsPlayers> TestList = new List<clsPlayers>();

            clsPlayers TestItem = new clsPlayers();



            TestItem.PlayerID = 6;
            TestItem.Name = "Mohamed Salah";
            TestItem.Team = "Liverpool";
            TestItem.Nationality = "Egypt";
            TestItem.Position = "Attacker";


            TestList.Add(TestItem);

            AllPlayers.PlayersList = TestList;

            Assert.AreEqual(AllPlayers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsPlayersCollection AllPlayers = new clsPlayersCollection();

            clsPlayers TestPlayers = new clsPlayers();

            Int32 PrimaryKey = 0;

            TestPlayers.PlayerID = 6;
            TestPlayers.Name = "Mohamed Salah";
            TestPlayers.Team = "Liverpool";
            TestPlayers.Nationality = "Egypt";
            TestPlayers.Position = "Attacker";

            AllPlayers.ThisPlayers = TestPlayers;

            PrimaryKey = AllPlayers.Add();

            TestPlayers.PlayerID = PrimaryKey;

            AllPlayers.ThisPlayers.Find(PrimaryKey);

            Assert.AreEqual(AllPlayers.ThisPlayers, TestPlayers);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsPlayersCollection AllPlayers = new clsPlayersCollection();

            clsPlayers TestPlayers = new clsPlayers();

            Int32 PrimaryKey = 0;

            TestPlayers.PlayerID = 6;
            TestPlayers.Name = "Mohamed Salah";
            TestPlayers.Team = "Liverpool";
            TestPlayers.Nationality = "Egypt";
            TestPlayers.Position = "Attacker";

            AllPlayers.ThisPlayers = TestPlayers;

            PrimaryKey = AllPlayers.Add();

            TestPlayers.PlayerID = PrimaryKey;

            TestPlayers.PlayerID = 6;
            TestPlayers.Name = "Mohamed Salah";
            TestPlayers.Team = "Liverpool";
            TestPlayers.Nationality = "Egypt";
            TestPlayers.Position = "Attacker";

            AllPlayers.ThisPlayers = TestPlayers;

            AllPlayers.Update();

            AllPlayers.ThisPlayers.Find(PrimaryKey);

            Assert.AreEqual(AllPlayers.ThisPlayers, TestPlayers);
        }

        [TestMethod]
        public void DeletedMethodOK()
        {
            clsPlayersCollection AllPlayers = new clsPlayersCollection();

            clsPlayers TestPlayers = new clsPlayers();

            Int32 PrimaryKey = 0;

            TestPlayers.PlayerID = 6;
            TestPlayers.Name = "Mohamed Salah";
            TestPlayers.Team = "Liverpool";
            TestPlayers.Nationality = "Egypt";
            TestPlayers.Position = "Attacker";

            AllPlayers.ThisPlayers = TestPlayers;

            PrimaryKey = AllPlayers.Add();

            TestPlayers.PlayerID = PrimaryKey;

            AllPlayers.ThisPlayers.Find(PrimaryKey);

            AllPlayers.Delete();

            Boolean Found = AllPlayers.ThisPlayers.Find(PrimaryKey);

            Assert.AreEqual(AllPlayers.ThisPlayers, TestPlayers);
        }

        [TestMethod]
        public void ReportByNameMethodOK()
        {
            clsPlayersCollection AllPlayers = new clsPlayersCollection();

            clsPlayersCollection FilteredPlayers = new clsPlayersCollection();

            FilteredPlayers.ReportByName("");

            Assert.AreEqual(AllPlayers.Count, FilteredPlayers.Count);
        }

        [TestMethod]
        public void ReportByNameCodeNotFound()
        {


            clsPlayersCollection FilteredPlayers = new clsPlayersCollection();

            FilteredPlayers.ReportByName("xxxxxxx");

            Assert.AreEqual(0, FilteredPlayers.Count);
        }

        [TestMethod]
        public void ReportByNameDataFound()
        {


            clsPlayersCollection FilteredPlayers = new clsPlayersCollection();

            Boolean OK = true;

            FilteredPlayers.ReportByName("Test Player");

            if (FilteredPlayers.Count == 2)
            {
                if (FilteredPlayers.PlayersList[0].PlayerID != 31)
                {
                    OK = false;
                }

                if (FilteredPlayers.PlayersList[1].PlayerID != 32)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}
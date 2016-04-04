using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetflixCatalogueSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem.Tests
{
    [TestClass()]
    public class ShowTests
    {
        [TestMethod()]
        public void AddEpisodeToShowTest()
        {
            //arrange 
            Genre testGenre = new Genre();
            Show testShow = new Show("Show1",3,"Comedy");
            List<Title> testList = new List<Title>();
            //act
            testGenre.AddTitleToGenre(testShow);
            testList.Add(testShow);
            //assert
            Assert.ReferenceEquals(testGenre.GenreTitleList, testList);
        }
        [TestMethod()]
        public void AddEpisodeToShow_CountIsOne_WithMovie()
        {
            Genre testGenre = new Genre();
            Movie testMovie = new Movie("Movie1",3,"Comedy",123);

            testGenre.AddTitleToGenre(testMovie);

            Assert.AreEqual(testGenre.GenreTitleList.Count, 1);
        }
        [TestMethod()]
        public void AddEpisodeToShow_CountIsTwo_WithMovieAndShow()
        {
            Genre testGenre = new Genre();
            Show testShow = new Show("Show1", 3, "Comedy");
            Movie testMovie = new Movie("Movie1",3,"Comedy",123);

            testGenre.AddTitleToGenre(testMovie);
            testGenre.AddTitleToGenre(testShow);

            Assert.AreEqual(testGenre.GenreTitleList.Count, 2);
        }

        [TestMethod()]
        public void AddEpisodeToShowTest_One()
        {
            Show testShow = new Show("Show1", 3, "Comedy");
            Episode testEpisode = new Episode(3, 123);

            testShow.AddEpisodeToShow(testEpisode);
            

            Assert.AreEqual(testShow.EpisodeCatalog.Count, 1);
        }
        [TestMethod()]
        public void AddEpisodeToShowTest_Two()
        {
            Show testShow = new Show("Show1", 3, "Comedy");
            Episode testEpisode = new Episode(4, 122);
            List<Episode> testList = new List<Episode>();

            testShow.AddEpisodeToShow(testEpisode);
            testList.Add(testEpisode);


            Assert.ReferenceEquals(testShow.EpisodeCatalog, testList);
        }

        [TestMethod()]
        public void TestToStringMethods()
        {
            Show testShow = new Show("Show1", 3, "Comedy");
            Movie testMovie = new Movie("Movie1", 2, "Comedy", 123);
            string testStringMovie = testMovie.ToString();
            string testStringShow = testShow.ToString();


            Assert.AreNotSame(testStringMovie, testStringShow);
        }
        [TestMethod()]
        public void TestEpisodeAggregatedRatings()
        {
            Show testShow = new Show("Show1", 3, "Comedy");
            Episode testEp1 = new Episode(4, 233);
            Episode testEp3 = new Episode(2, 233);

            testShow.AddEpisodeToShow(testEp1);
            testShow.AddEpisodeToShow(testEp3);

            Assert.AreEqual(3, testShow.Rating);
        }
        [TestMethod()]
        public void TestPlusOperatorGenre()
        {
            Genre testGenre = new Genre();
            Show testShow1 = new Show("",4,"");
            Show testShow2 = new Show("", 5, "");
            Genre testGenre2 = new Genre();
            Show testShow3 = new Show("", 3, "");
            Show testShow4 = new Show("", 4, "");
            testGenre.AddTitleToGenre(testShow1);
            testGenre.AddTitleToGenre(testShow2);
            testGenre2.AddTitleToGenre(testShow3);
            testGenre2.AddTitleToGenre(testShow4);
            Genre testGenre3 = testGenre + testGenre2;
            Assert.AreEqual(testGenre3.GenreTitleList.Count, 4);
        }
        [TestMethod()]
        public void TestPlusOperatorGenreAndTitle()
        {
            Genre testGenre = new Genre();
            Show testShow1 = new Show("", 4, "");
            Show testShow2 = new Show("", 5, "");
            Show testShow4 = new Show("", 4, "");
            testGenre.AddTitleToGenre(testShow1);
            testGenre.AddTitleToGenre(testShow2);
            Genre testGenre3 = testGenre + testShow4;
            Assert.AreEqual(testGenre3.GenreTitleList.Count, 3);
        }

        [TestMethod()]
        public void TestEpisodeAggregatedRatingsVsTestEp2()
        {
            Show testShow = new Show("Show1", 3, "Comedy");
            Show testShow2 = new Show("Show1", 3, "Comedy");
            Episode testEp2 = new Episode(3, 234);
            Episode testEp1 = new Episode(4, 243);
            Episode testEp3 = new Episode(2, 233);
            testShow.AddEpisodeToShow(testEp1);
            testShow.AddEpisodeToShow(testEp3);
            testShow2.AddEpisodeToShow(testEp2);

            Assert.AreEqual(testShow.Rating, testShow2.Rating);
        }

    }
}
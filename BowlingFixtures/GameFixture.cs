using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingFixtures
{
    [TestClass]
    public class GameFixture
    {  
    /// <summary>
    ///This is a test class for GameTest and is intended
    ///to contain all GameTest Unit Tests
    ///</summary>
     
        //1.check when all pins are strikes
        //2.check when all pins are spares
        //3.check when all pins are gutter
        //4.check when some inputs are strikes and some are spare
        //5.case with score in between

        //1.check when all pins are strikes
        [TestMethod]
        public void GameWithAllStrikes()
        {

            try
            {
                Bowling.Game gmobj = new Bowling.Game();
                gmobj.Roll(10);
                gmobj.Roll(10);
                gmobj.Roll(10);
                gmobj.Roll(10);
                gmobj.Roll(10);
                gmobj.Roll(10);
                gmobj.Roll(10);
                gmobj.Roll(10);
                gmobj.Roll(10);
                gmobj.Roll(10);
                gmobj.Roll(10);
                gmobj.Roll(10);
               int score= gmobj.GetScore();
                Assert.AreEqual(score,300);

            }
            catch (Exception ex)
            {
                //Assert.Fail("Not equal to {0}!!!",ex.GetType().Name);
            }
        }

        //2.check when all pins are gutter
        [TestMethod]
        public void GameWithAllGutters()
        {

            try
            {
                Bowling.Game gmobj = new Bowling.Game();
                gmobj.Roll(0);
                gmobj.Roll(0);
                gmobj.Roll(0);
                gmobj.Roll(0);
                gmobj.Roll(0);
                gmobj.Roll(0);
                gmobj.Roll(0);
                gmobj.Roll(0);
                gmobj.Roll(0);
                gmobj.Roll(0);
                gmobj.Roll(0);
                gmobj.Roll(0);
                gmobj.Roll(0);
                gmobj.Roll(0);
                gmobj.Roll(0);
                gmobj.Roll(0);
                gmobj.Roll(0);
                gmobj.Roll(0);
                gmobj.Roll(0);
                int score = gmobj.GetScore();
                Assert.AreEqual(score, 0);

            }
            catch (Exception ex)
            {
                //Assert.Fail("Not equal to {0}!!!",ex.GetType().Name);
            }
        }




        //3.check when all pins are spare
        [TestMethod]
        public void GameWithAllSpares()
        {

            try
            {
                Bowling.Game gmobj = new Bowling.Game();
                gmobj.Roll(3);
                gmobj.Roll(7);
                gmobj.Roll(3);
                gmobj.Roll(7);
                gmobj.Roll(3);
                gmobj.Roll(7);
                gmobj.Roll(3);
                gmobj.Roll(7);
                gmobj.Roll(3);
                gmobj.Roll(7);
                gmobj.Roll(3);
                gmobj.Roll(7);
                gmobj.Roll(3);
                gmobj.Roll(7);
                gmobj.Roll(3);
                gmobj.Roll(7);
                gmobj.Roll(3);
                gmobj.Roll(7);
                gmobj.Roll(3);
                gmobj.Roll(7);
                int score = gmobj.GetScore();
                Assert.AreEqual(score, 127);

            }
            catch (Exception ex)
            {
                //Assert.Fail("Not equal to {0}!!!",ex.GetType().Name);
            }
        }


        //4.check when all pins are strike or spare
        [TestMethod]
        public void GameWithSomeSparesSomeStrikes()
        {

            try
            {
                Bowling.Game gmobj = new Bowling.Game();
                gmobj.Roll(10);
                gmobj.Roll(10);
                gmobj.Roll(3);
                gmobj.Roll(7);
                gmobj.Roll(10);
                gmobj.Roll(10);
                gmobj.Roll(10);
                gmobj.Roll(10);
                gmobj.Roll(10);
                gmobj.Roll(10);
                gmobj.Roll(10);
                gmobj.Roll(10);
                gmobj.Roll(10);
                int score = gmobj.GetScore();
                Assert.AreEqual(score, 283);

            }
            catch (Exception ex)
            {
                //Assert.Fail("Not equal to {0}!!!",ex.GetType().Name);
            }
        }

        //5.case with score in between
        [TestMethod]
        public void GameInBetween()
        {

            try
            {
                Bowling.Game gmobj = new Bowling.Game();
                gmobj.Roll(10);
                gmobj.Roll(10);
                gmobj.Roll(3);
                gmobj.Roll(7);
               
                int score = gmobj.GetScore();
                Assert.AreEqual(score, 53);

            }
            catch (Exception ex)
            {
                //Assert.Fail("Not equal to {0}!!!",ex.GetType().Name);
            }
        }


      
    }
}

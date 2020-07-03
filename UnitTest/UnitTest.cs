using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RussianRoulette;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        RRclass RRc = new RRclass();

        [TestMethod]
        public void TestMethod1() //Checking there is only 1 bullet in gun
        {
            int[] gunChmbers = { 0, 0, 0, 0, 0, 0 }; //Empty gun
            int bullCount = 0;

            RRc.LoadBull();

            for (int i = 5; i >= 0; i--)
            {

                bullCount = bullCount + gunChmbers[i];
            }

            Assert.IsFalse(bullCount > 1);
        }

        [TestMethod]
        public void TestMethod2() //Checking that you can run out of Chances
        {
            string lastChance = RRc.ShootAwy(1, out int awayShots, 6, out int ChmberNum, out int ptsChange);
            int scoreChnge = ptsChange;

            Assert.IsTrue(scoreChnge == -15);
        }

        [TestMethod]
        public void TestMethod3() //Checking that both lose situations have same penalty
        {

            string lastChance = RRc.ShootAwy(1, out int awayShots, 6, out int ChmberNum, out int ptsChange); //Run out of chances
            int scoreChnge1 = ptsChange;

            int[] gunChmbers = { 0, 0, 0, 0, 0, 1 };

            string shotDead = RRc.ShootAwy(1, out int awayShots2, 6, out int ChmberNum2, out int ptsChange2); //Shot self
            int scoreChnge2 = ptsChange2;

            Assert.AreEqual(scoreChnge1, scoreChnge2);
        }
    }
}

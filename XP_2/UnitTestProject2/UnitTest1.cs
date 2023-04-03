using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodNeg()
        {
            string jmeno = XP_2.Form1.VratJmeno("Tonda");
            Assert.IsNull(jmeno);
        }
        [TestMethod]
        public void TestMethodPos()
        {
            string jmeno = XP_2.Form1.VratJmeno("Tonda");
            Assert.IsNotNull(jmeno);
        }
        [TestMethod]
        public void TestMethodNeg1()
        {
            string jmeno = XP_2.Form1.VratJmeno("Tonda");
            Assert.IsTrue(jmeno.Length > 10);
        }
        [TestMethod]
        public void TestMethodPos1()
        {
            string jmeno = XP_2.Form1.VratJmeno("Tonda") + "2454asd";
            Assert.IsTrue(jmeno.Length > 10);
        }
        [TestMethod]
        public void TestMethodNeg2()
        {
            string jmeno = XP_2.Form1.VratJmeno("Tonda");
            Assert.IsTrue(jmeno.Contains("&"));
        }
        [TestMethod]
        public void TestMethodPos2()
        {
            string jmeno = XP_2.Form1.VratJmeno("Tonda");
            Assert.IsTrue(jmeno.Contains("Tonda"));
        }
        [TestMethod]
        public void TestMethodNeg3()
        {
            XP_2.Form1 form = new XP_2.Form1();
            string specializace = XP_2.Form1.VratSpecializaci("Berserker");
            Assert.AreSame(specializace, "Kouzelník");
        }
        [TestMethod]
        public void TestMethodPos3()
        {
            string specializace = XP_2.Form1.VratSpecializaci("Berserker");
            Assert.AreSame(specializace, "Berserker");
        }
        [TestMethod]
        public void TestMethodNeg4()
        {
            double aktualni1 = XP_2.Form1.VratXP(20);
            int aktualni2 = XP_2.Form1.VratXP(20);
            Assert.AreSame(aktualni1, aktualni2);
        }
        [TestMethod]
        public void TestMethodPos4()
        {
            int aktualni = XP_2.Form1.VratXP(20);
            Assert.AreEqual(aktualni, XP_2.Form1.VratXP(20));
        }
        [TestMethod]
        public void TestMethodNeg5()
        {
            int X = XP_2.Form1.ZmenaPoziceX(2);
            int Y = XP_2.Form1.ZmenaPoziceY(5);
            Assert.IsFalse(X < Y);
        }
        [TestMethod]
        public void TestMethodPos5()
        {
            int X = XP_2.Form1.ZmenaPoziceX(2);
            int Y = XP_2.Form1.ZmenaPoziceY(5);
            Assert.IsFalse(X > Y);
        }
    }
}

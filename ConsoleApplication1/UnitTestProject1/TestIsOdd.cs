using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class TestIsOdd
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool result3 = Program.IsOdd(3);
            Assert.AreEqual(true, result3);

            bool result4 = Program.IsOdd1(4);
            Assert.AreEqual(false, result4);
        }
    }
}

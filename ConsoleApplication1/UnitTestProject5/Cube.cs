using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject5
{
    [TestClass]
    public class Cube
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result1 = Program.Cube((int)2);
            Assert.AreEqual(8, result1);

            int result2 = Program.Cube((int)-5);
            Assert.AreEqual(-125, result2);
        }
    }
}

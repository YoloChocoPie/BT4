using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
namespace TestPow
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result1 = Program.Abs((int)2);
            Assert.AreEqual(2, result1);

            int result2 = Program.Abs((int)-5);
            Assert.AreEqual(5, result2);
        }
    }
}

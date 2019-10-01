using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace TestFloor
{
    [TestClass]
    public class TestFloor
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result1 = Program.TestFloor((float)2.3);
            Assert.AreEqual(2, result1);

            int result2 = Program.TestFloor((float)-2.3);
            Assert.AreEqual(-2, result2);

            int result3 = Program.TestFloor((float)3);
            Assert.AreEqual(3, result3);
        }
    }
}

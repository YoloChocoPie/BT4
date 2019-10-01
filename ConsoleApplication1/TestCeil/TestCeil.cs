using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace TestCeil
{
    [TestClass]
    public class TestCeil
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result1 = Program.TestCeil((float)2.3);
            Assert.AreEqual(3, result1);

            int result2 = Program.TestCeil((float)-2.3);
            Assert.AreEqual(-2, result2);

            int result3 = Program.TestCeil((float)4);
            Assert.AreEqual(4, result3);
        }
    }
}

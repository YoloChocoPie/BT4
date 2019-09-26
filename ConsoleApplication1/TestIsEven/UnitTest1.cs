using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace TestIsEven
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool result3 = Program.IsEven(3);
            Assert.AreEqual(false, result3);

            bool result4 = Program.IsEven1(4);
            Assert.AreEqual(true, result4);
        }
    }
}

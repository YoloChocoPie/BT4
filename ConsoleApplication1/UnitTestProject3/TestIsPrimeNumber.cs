using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject3
{
    [TestClass]
    public class TestIsPrimeNumber
    {
        [TestMethod]
        public void TestMethod1()
        {
           bool result1 = Program.IsPrimeNumber1(1);
           Assert.AreEqual(false, result1);

           bool result3 = Program.IsPrimeNumber(3);
           Assert.AreEqual(true, result3);

           bool result2 = Program.IsPrimeNumber1(-3);
           Assert.AreEqual(false, result2);

        }
    }
}

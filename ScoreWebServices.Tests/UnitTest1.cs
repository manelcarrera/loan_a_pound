using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ScoreWebServices.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_ws1()
        {
            refweb1.WebService1 ws1 = new refweb1.WebService1();
            Assert.AreEqual(ws1.getScore(), 100 );
        }
        [TestMethod]
        public void TestMethod_ws2()
        {
            refweb2.WebService2 ws2 = new refweb2.WebService2();
            Assert.AreEqual(ws2.getScore(), 200);
        }
    }
}

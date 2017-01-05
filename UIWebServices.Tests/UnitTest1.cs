using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UIWebServices.Tests
{
    [TestClass]
    public class UnitTest_ApplicantDesktopWS
    {
        [TestMethod]
        public void TestMethod_getApplication()
        {
            ref1.ApplicantDesktopWS ws = new ref1.ApplicantDesktopWS();

            //Assert.AreEqual(ws.getApplication(), 100);

            //Assert.IsNotNull

        }
        [TestMethod]
        public void TestMethod_setApplication()
        {
        }
    }

    [TestClass]
    public class UnitTest_UnderwritterDesktopWS
    {
    }

    [TestClass]
    public class UnitTest_AdminDesktopWS
    {
        [TestMethod]
        public void TestMethod_getLoan()
        {
        }
    }

}

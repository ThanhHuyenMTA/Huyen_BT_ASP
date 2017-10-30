using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            Assert.AreEqual(true, BT2.Bai24.testSNT(17));
            Assert.AreEqual(false, BT2.Bai24.testSNT(50));
            Assert.AreEqual(true, BT2.Bai24.testSNT(41));
            Assert.AreEqual(false, BT2.Bai24.testSNT(111));


            
        }
    }
}

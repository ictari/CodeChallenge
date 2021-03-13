using Challenge.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var service = new Service();

            Assert.AreEqual("1", service.Get(1));
            Assert.AreEqual("E", service.Get(7));
            Assert.AreEqual("G", service.Get(9));
            Assert.AreEqual("EG", service.Get(63));
        }
    }
}
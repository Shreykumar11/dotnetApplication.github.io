using Microsoft.VisualStudio.TestTools.UnitTesting;
using Addition;

namespace TestCases
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Add add = new Add();
            Assert.AreEqual(97, add.Main(7, 90));
        }
    }
}
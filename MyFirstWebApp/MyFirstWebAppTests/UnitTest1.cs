using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstWebApp.Controllers;

namespace MyFirstWebAppTests
{
    [TestClass]
    public class UnitTest1
    {
        CalculatorController test = new CalculatorController();
        
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(78, test.Add(70, 8));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(65, test.Subtract(70, 5));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(100, test.Multiply(10, 10));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(7, test.Divide(70, 10));
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kolokwium1;

namespace Kolokwium1Test
{
    [TestClass]
    public class FullComplexNumberTest
    {
        [TestMethod]
        public void TestMethodModule()
        {
            FullComplexNumber fcn = new FullComplexNumber(3, 4);
            Assert.AreEqual(5d, fcn.getR());
        }

        [TestMethod]
        public void TestMethodSin()
        {
            FullComplexNumber fcn = new FullComplexNumber(3, 4);
            Assert.AreEqual(0.8, fcn.getSin());
        }

        [TestMethod]
        public void TestMethodCos()
        {
            FullComplexNumber fcn = new FullComplexNumber(3, 4);
            Assert.AreEqual(0.6, fcn.getCos());
        }
    }
}

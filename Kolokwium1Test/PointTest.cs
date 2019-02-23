using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kolokwium1;

namespace Kolokwium1Test
{
    [TestClass]
    public class PointTest
    {
        [TestMethod]
        public void Testinheritance()
        {
            TPoint point = new TPoint();
            Assert.IsInstanceOfType(point, typeof(TAbstractPoint));
        }

        [TestMethod]
        public void TestDefaultConstructor()
        {
            TPoint point = new TPoint();

            Assert.AreEqual(0, point.X);
            Assert.AreEqual(0, point.Y);
        }

        [TestMethod]
        public void TestConstructorWithParameters()
        {
            TPoint point = new TPoint(1.23, 4.5345);

            Assert.AreEqual(1.23, point.X);
            Assert.AreEqual(4.5345, point.Y);
        }

        [TestMethod]
        public void TestMoveXYMethod()
        {
            TPoint point = new TPoint(1.23, 4.5344);
            point.moveXY(3.34, 2.24);

            Assert.AreEqual(4.57, point.X);
            Assert.AreEqual(6.7744, point.Y);
        }

        [TestMethod]
        public void TestReverseMethod()
        {
            TPoint point = new TPoint(4.59, 6.7745);
            point.reverse();

            Assert.AreEqual(-4.59, point.X);
            Assert.AreEqual(-6.7745, point.Y);
        }

        [TestMethod]
        public void TestTeciprocalMethodTrue()
        {
            TPoint point = new TPoint(0.25, 40);
            bool expectedexBool = point.reciprocal();

            Assert.IsTrue(expectedexBool);
            Assert.AreEqual(4, point.X);
            Assert.AreEqual(0.025, point.Y);
        }

        [TestMethod]
        public void TestTeciprocalMethodFalse()
        {
            TPoint point = new TPoint(0, 40);
            bool expectedexBool = point.reciprocal();

            Assert.IsFalse(expectedexBool);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kolokwium1;

namespace Kolokwium1Test
{
    [TestClass]
    public class SegmentTest
    {
        [TestMethod]
        public void TestConstructorWithParameters()
        {
            TSegment segment = new TSegment(new TPoint(1, 2), new TPoint(3, 4));

            Assert.AreEqual(1, segment.First.X);
            Assert.AreEqual(2, segment.First.Y);
            Assert.AreEqual(3, segment.Last.X);
            Assert.AreEqual(4, segment.Last.Y);
        }

        [TestMethod]
        public void TestDefaultConstructor()
        {
            TSegment segment = new TSegment();

            Assert.AreEqual(0, segment.First.X);
            Assert.AreEqual(0, segment.First.Y);
            Assert.AreEqual(0, segment.Last.X);
            Assert.AreEqual(0, segment.Last.Y);
        }

        [TestMethod]
        public void TestEuklidesMethod()
        {
            TSegment segment = new TSegment(new TPoint(1, 1), new TPoint(4, 5));

            Assert.AreEqual(5, segment.Euklides());
        }

        [TestMethod]
        public void TestManhattanMethod()
        {
            TSegment segment = new TSegment(new TPoint(1, 1), new TPoint(4, 5));

            Assert.AreEqual(7, segment.Manhattan());
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kolokwium1;

namespace Kolokwium1Test
{
    [TestClass]
    public class RasterSegmentTest
    {
        [TestMethod]
        public void TestMethodCount()
        {
            TRasterSegment trs = new TRasterSegment(new TPoint(0, 0), new TPoint(11, 11));
            Assert.AreEqual(10, trs.AdditionalPoints.Count);
        }

        [TestMethod]
        public void TestMethodGetX()
        {
            TRasterSegment trs = new TRasterSegment(new TPoint(), new TPoint(11, 11));
            Assert.AreEqual(10, trs.AdditionalPoints[9].X);
        }

        [TestMethod]
        public void TestMethodGetY()
        {
            TRasterSegment trs = new TRasterSegment(new TPoint(0, 0), new TPoint(11, 11));
            Assert.AreEqual(4, trs.AdditionalPoints[3].Y);
        }
    }
}

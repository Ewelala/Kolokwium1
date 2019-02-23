using System;
using Kolokwium1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kolokwium1Test
{
    [TestClass]
    public class ComplexNumberTest
    {
        
       
            [TestMethod]
            public void TestMethodGetRel()
            {
                ComplexNumber cn = new ComplexNumber(7, -2);
                Assert.AreEqual(7, cn.getRel());
            }

            [TestMethod]
            public void TestMethodGetIm()
            {
                ComplexNumber cn = new ComplexNumber(7, -2);
                Assert.AreEqual(-2, cn.getIm());
            }

            [TestMethod]
            public void TestMethodAdd()
            {
                ComplexNumber cn1 = new ComplexNumber(3, -2);
                ComplexNumber cn2 = new ComplexNumber(-4, 9);

                ComplexNumber w = cn1 + cn2;

                Assert.AreEqual(-1d, w.getRel());
                Assert.AreEqual(7d, w.getIm());
            }

            [TestMethod]
            public void TestMethodSub()
            {
                ComplexNumber cn1 = new ComplexNumber(-5, 4);
                ComplexNumber cn2 = new ComplexNumber(2, 2);

                ComplexNumber w = cn1 - cn2;

                Assert.AreEqual(-7d, w.getRel());
                Assert.AreEqual(2d, w.getIm());
            }

            [TestMethod]
            public void TestMethodDiv()
            {
                ComplexNumber cn1 = new ComplexNumber(2, -3);
                ComplexNumber cn2 = new ComplexNumber(5, 4);

                ComplexNumber w = cn1 / cn2;

                Assert.AreEqual(-2d / 41, w.getRel());
                Assert.AreEqual(-23d / 41, w.getIm());
            }

            [TestMethod]
            public void TestMethodMul()
            {
                ComplexNumber cn1 = new ComplexNumber(Math.Sqrt(5), 2);
                ComplexNumber cn2 = new ComplexNumber(2, Math.Sqrt(2));

                ComplexNumber w = cn1 * cn2;

                Assert.AreEqual(2 * Math.Sqrt(5) - 2 * Math.Sqrt(2), w.getRel());
                Assert.AreEqual(Math.Sqrt(10) + 4, w.getIm());
            }
        }
    }



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolokwium1
{
    public class FullComplexNumber : ComplexNumber
    {
        public FullComplexNumber() : base()
        { }

        public FullComplexNumber(double _rel, double _im) : base(_rel, _im)
        { }

        public double getR()
        {
            return Math.Sqrt(Math.Pow(getRel(), 2) + Math.Pow(getIm(), 2));
        }

        public double getCos()
        {
            return getRel() / getR();
        }

        public double getSin()
        {
            return getIm() / getR();
        }
    }
}

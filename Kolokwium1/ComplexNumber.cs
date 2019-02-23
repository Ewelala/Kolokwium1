using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolokwium1
{
    public class ComplexNumber : TAbstractPoint
    {
        double im;

        public ComplexNumber() : this(0, 0)
        { }

        public ComplexNumber(double _rel, double _im)
        {
            x = _rel;
            im = _im;
        }

        public double getRel()
        {
            return x;
        }

        public double getIm()
        {
            return im;
        }

        public static ComplexNumber operator +(ComplexNumber p1, ComplexNumber p2)
        {
            return new ComplexNumber(p1.getRel() + p2.getRel(), p1.getIm() + p2.getIm());
        }

        public static ComplexNumber operator -(ComplexNumber p1, ComplexNumber p2)
        {
            return new ComplexNumber(p1.getRel() - p2.getRel(), p1.getIm() - p2.getIm());
        }

        public static ComplexNumber operator *(ComplexNumber p1, ComplexNumber p2)
        {
            double a = p1.getRel() * p2.getRel() - p1.getIm() * p2.getIm();
            double b = p1.getRel() * p2.getIm() + p2.getRel() * p1.getIm();
            return new ComplexNumber(a, b);
        }

        public static ComplexNumber operator /(ComplexNumber p1, ComplexNumber p2)
        {
            double d = Math.Pow(p2.getRel(), 2) + Math.Pow(p2.getIm(), 2);
            double a = (p1.getRel() * p2.getRel() + p1.getIm() * p2.getIm()) / d;
            double b = (p1.getIm() * p2.getRel() - p1.getRel() * p2.getIm()) / d;

            return new ComplexNumber(a, b);
        }

        public void print()
        {
            Console.WriteLine("Re z = {0}", getRel());
            Console.WriteLine("Im z = {0}", getIm());
        }

        public override void moveXY(double _x, double _y)
        {
            throw new NotImplementedException();
        }

        public override bool reciprocal()
        {
            throw new NotImplementedException();
        }
    }
}

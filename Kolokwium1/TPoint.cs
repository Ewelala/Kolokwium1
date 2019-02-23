using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Kolokwium1
{
    public class TPoint : TAbstractPoint
    {
        protected double y;

        public double Y
        {
            get { return y; }
        }

        public double X
        {
            get { return x; }
        }

        public TPoint() : this(0, 0)
        { }

        public TPoint(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        public override void moveXY(double _x, double _y)
        {
            x += _x;
            y += _y;
        }

        public override bool reciprocal()
        {
            bool ret = false;

            if (x != 0 && y != 0)
            {
                x = 1 / x;
                y = 1 / y;
                ret = true;
            }

            return ret;
        }

        public override void reverse()
        {
            base.reverse();
            y = -y;
        }

        public void print()
        {
            Console.WriteLine("x = {0}, y = {1}", x, y);
        }
    }
}

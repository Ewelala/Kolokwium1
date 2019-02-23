using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolokwium1
{
    public abstract class TAbstractPoint
    {
        protected double x;
        public abstract void moveXY(double _x, double _y);
        public abstract bool reciprocal();

        public virtual void reverse()
        {
            x = -x;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolokwium1
{
    public class TSegment
    {
        protected TPoint first;
        protected TPoint last;

        public TSegment() : this(new TPoint(0, 0), new TPoint(0, 0))
        {
        }

        public TSegment(TPoint _first, TPoint _last)
        {
            first = _first;
            last = _last;
        }

        public TPoint First
        {
            get
            {
                return first;
            }
        }

        public TPoint Last
        {
            get
            {
                return last;
            }
        }

        public double Euklides()
        {
            return Math.Sqrt(Math.Pow(last.X - first.X, 2) + Math.Pow(last.Y - first.Y, 2));
        }

        public double Manhattan()
        {
            return Math.Abs(first.X - last.X) + Math.Abs(first.Y - last.Y);
        }

        public void Print()
        {
            Console.WriteLine("Punkty należące do odcinka:");
            first.print();
            last.print();
        }
    }
}



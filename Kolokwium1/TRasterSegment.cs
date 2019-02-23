using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolokwium1
{
    public class TRasterSegment : TSegment
    {
        List<TPoint> additionalPoints;

        public TRasterSegment(TPoint _first, TPoint _last) : base(_first, _last)
        {
            additionalPoints = new List<TPoint>();

            double Dab = Euklides();
            double Dan = Dab / 11;
            double Dx = last.X - first.X;
            double Dy = last.Y - first.Y;

            for (int i = 1; i < 11; i++)
            {

                double Xan = (Dan * i) * (Dx / Dab);
                double Yan = (Dan * i) * (Dy / Dab);

                double Xn = first.X + Xan;
                double Yn = first.Y + Yan;

                additionalPoints.Add(new TPoint(Xn, Yn));

            }
        }

        public List<TPoint> AdditionalPoints
        {
            get
            {
                return additionalPoints;
            }
        }

        public void print()
        {
            Console.WriteLine("Odcinek o początku ({0},{1}) i koncu ({2},{3})\nZawiera punkty:", first.X, first.Y, last.X, last.Y);
            foreach (var item in additionalPoints)
            {
                item.print();
            }
        }
    }
}

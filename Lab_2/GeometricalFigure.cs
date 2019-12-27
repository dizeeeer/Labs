using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public abstract class GeometricalFigure : IComparable
    {
        public string Type { get; protected set; }

        public abstract double Area();

        public int CompareTo(object obj)
        {
            GeometricalFigure figure = (GeometricalFigure)obj;

            if (this.Area() < figure.Area())
                return -1;

            else if (this.Area() == figure.Area())
                return 0;

            else return 1;
        }
    }
}
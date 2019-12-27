using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2;

namespace Lab_3
{
    class FigureMatrixCheckEmpty : IMatrixCheckEmpty<GeometricalFigure>
    {
        public GeometricalFigure getEmptyElement()
        {
            return null;
        }
        public bool checkEmptyElement(GeometricalFigure element)
        {
            bool Result = false;
            if(element == null)
            {
                Result = true;
            }
            return Result;
        }
    }
}

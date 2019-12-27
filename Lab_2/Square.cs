using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public class Square : Rectangle, IPrint
    {
        public Square(double size) : base(size, size)
        {
            this.Type = "Квадрат";
        }
        public override string ToString()
        {
            return this.Type + " с длиной стороны: " + this.width.ToString() + " имеет площадь: " + this.Area().ToString();
        }
    }
}
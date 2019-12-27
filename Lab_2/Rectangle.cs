using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
   public class Rectangle : GeometricalFigure, IPrint
    {
        public double height { get; set; }
        public double width { get; set; }
        public Rectangle(double w, double h)
        {
            height = h;
            width = w;
            this.Type = "Прямоугольник";
        }

        public override double Area()
        {
            double result = this.width * this.height;
            if (result < 0)
            {
                Console.WriteLine("Введенные данные должны быть неотрицательынми!");
                return -1;
            }
            else return result;
        }

        public override string ToString()
        {
            return this.Type + " с шириной: " + this.width.ToString() + " и с высотой: " + this.height.ToString() + " имеет площадь: " + this.Area().ToString();
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
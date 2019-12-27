using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public class Circle : GeometricalFigure, IPrint
    {
        public double radius { get; set; }
        public Circle(double r)
        {
            this.radius = r;
            this.Type = "Круг";
        }
        public override double Area()
        {
            double result = Math.PI * this.radius * this.radius;
            if (result < 0)
            {
                Console.WriteLine("Введенные данные должны быть неотрицательынми!");
                return -1;
            }
            else return result;
        }
        public override string ToString()
        {
            return this.Type + " с радиусом: " + this.radius.ToString() + " имеет площадь: " + this.Area().ToString();
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
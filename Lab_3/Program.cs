using System;
using System.Collections;
using System.Collections.Generic;
using Lab_2;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Енин Александр ИУ5-34Б";
            Rectangle rectangle = new Rectangle(9, 6);
            Circle circle = new Circle(9);
            Square square = new Square(6);
            

            ArrayList f1 = new ArrayList();

            f1.Add(rectangle);
            f1.Add(square);
            f1.Add(circle);

            Console.WriteLine("\nСодержимое коллекции ArrayList: ");
            foreach (var x in f1)
                Console.WriteLine(x.ToString());

            for (int i = 0; i < 50; i++)
                Console.Write("-");
            ////////////////////////

            Console.Write("\nКоллекция класса List<Figure>");
            List<GeometricalFigure> f2 = new List<GeometricalFigure>();
            f2.Add(circle);
            f2.Add(rectangle);
            f2.Add(square);

            Console.WriteLine("\nПеред сортировкой: ");
            foreach (var x in f2)
                Console.WriteLine(x.ToString());

            f2.Sort();
            Console.WriteLine("\nПосле сортировки: ");
            foreach (var x in f2)
                Console.WriteLine(x.ToString());

            for (int i = 0; i < 50; i++)
                Console.Write("-");
            ////////////////////////

            Console.WriteLine("\nМатрица: ");
            Matrix<GeometricalFigure> matrix = new Matrix<GeometricalFigure>(3, 3, new FigureMatrixCheckEmpty());

            matrix[0, 0] = rectangle;
            matrix[1, 1] = square;
            matrix[2, 2] = circle;
            Console.WriteLine(matrix.ToString());

            for (int i = 0; i < 50; i++)
                Console.Write("-");
            Console.WriteLine("\n");
            ////////////////////////


            Console.WriteLine("\nSimpleStack: ");
            SimpleStack<GeometricalFigure> stack = new SimpleStack<GeometricalFigure>();
            stack.Push(rectangle);
            stack.Push(square);
            stack.Push(circle);

            while (stack.Count > 0)
            {
                GeometricalFigure f = stack.Pop();
                Console.WriteLine(f);
            }
          
            Console.ReadKey();

        }
    }
}

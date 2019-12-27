using System;


namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Енин Александр ИУ5-34Б";
            Rectangle rect = new Rectangle(3, 4);
            Square square = new Square(5);
            Circle circle = new Circle(6);

            rect.Print();
            square.Print();
            circle.Print();

            Console.ReadKey();

        }
    }
}
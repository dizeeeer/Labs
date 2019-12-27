using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {   
        static void color(int k)
        {
            switch (k) {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }
        }
        static int Main(string[] args)
        {
            Console.Title = "Енин Александр ИУ5-34Б";

            bool f1, f2, f3;
            double a, b, c;

            if (args.Length == 3)
            {
                try
                {
                    a = Convert.ToDouble(args[0]);
                    b = Convert.ToDouble(args[1]);
                    c = Convert.ToDouble(args[2]);
                }
                catch (Exception)
                {
                    color(1);
                    Console.WriteLine("Введите вещественные числа в параметрах командной строки!");
                    return (0);
                }
               // Console.WriteLine(a.ToString());
               // Console.WriteLine(b.ToString());
              //  Console.WriteLine(c.ToString());
            }

            else
            {
                do
                {
                    Console.Write("Введите коэффициент А: ");
                    f1 = double.TryParse(Console.ReadLine(), out a);
                    Console.Write("Введите коэффициент B: ");
                    f2 = double.TryParse(Console.ReadLine(), out b);
                    Console.Write("Введите коэффициент C: ");
                    f3 = double.TryParse(Console.ReadLine(), out c);

                    if (!f1 || !f2 || !f3)
                    {
                        Console.WriteLine("Необходимо ввести вещественные числа!");
                    }
                } while (!f1 || !f2 || !f3);

               // Console.WriteLine(a.ToString());
                //Console.WriteLine(b.ToString());
                //Console.WriteLine(c.ToString());
            }
                if (a == 0 && b == 0 && c == 0)
                {
                    color(2);
                    Console.WriteLine("Бесконечное Количество Корней");
                    Console.ReadLine();
                    return (0);
                }

                if (a == 0 && b == 0)
                {
                    color(1);
                    Console.WriteLine("Корней Нет");
                Console.ReadLine();
                return (0);
                }

                if (a == 0)
                {
                    double var1 = -c / b;
                    if (var1 < 0)
                    {
                        color(1);
                        Console.WriteLine("корней Нет");
                    Console.ReadLine();
                    return (0);
                    }
                    else if (var1 == 0)
                    {
                        color(2);
                        Console.WriteLine("x1=0");
                    Console.ReadLine();
                    return (0);
                    }
                    else
                    {
                        color(2);
                        double x1 = Math.Sqrt(var1), x2 = -Math.Sqrt(var1);
                        Console.WriteLine("x1= " + x1.ToString() + " x2= " + x2.ToString());
                    Console.ReadLine();
                    return (0);
                    }
                }

                if (b == 0)
                {
                    double var2 = -c / a;
                    if (var2 < 0)
                    {
                        color(1);
                        Console.WriteLine("корней Нет");
                    Console.ReadLine();
                    return (0);
                    }
                    else if (var2 == 0)
                    {
                        color(2);
                        Console.WriteLine("x1=0");
                    Console.ReadLine();
                    return (0);
                    }
                    else
                    {
                        color(2);
                        double y1 = Math.Sqrt(var2);
                        double x1 = Math.Sqrt(y1), x2 = -Math.Sqrt(y1);
                        Console.WriteLine("x1= " + x1.ToString() + " x2= " + x2.ToString());
                    Console.ReadLine();
                    return (0);
                    }

                }
                else
                {
                    double d = b * b - 4 * a * c;

                    if (d < 0)
                    {
                        color(1);
                        Console.WriteLine("корней Нет");
                    Console.ReadLine();
                    return (0);
                    }
                    double t1, t2;
                    List<double> list = new List<double>();
                    t1 = (-b + Math.Sqrt(d)) / (2 * a);
                    t2 = (-b - Math.Sqrt(d)) / (2 * a);

                    if (t1 < 0 && t2 < 0)
                    {
                        color(1);
                        Console.WriteLine("корней Нет");
                    Console.ReadLine();
                    return (0);
                    }
                    if (t1 == 0)
                    {
                        list.Add(t1);
                    }
                    if (t1 > 0)
                    {
                        list.Add(Math.Sqrt(t1));
                        list.Add(-Math.Sqrt(t1));
                    }
                    if (t1 != t2)
                    {
                        if (t2 == 0) list.Add(t2);
                        if (t2 > 0)
                        {
                            list.Add(Math.Sqrt(t2));
                            list.Add(-Math.Sqrt(t2));
                        }
                    }

                    int i1 = 0;
                    color(2);
                    foreach (double i2 in list)
                    {
                        i1++;
                        Console.WriteLine("x" + i1.ToString() + "=" + i2.ToString());
                    }


                }
            Console.ReadLine();
            return (0);
            
        }
    }
}

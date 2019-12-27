using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Lab_6
{

    class Program
    {
        public static bool GetPropertyAttribute(PropertyInfo checkType, Type attributeType, out object attribute)
        {
            attribute = null;
            var isAttribute = checkType.GetCustomAttributes(attributeType, false);

            if (isAttribute.Length > 0)
            {
                attribute = isAttribute[0];
                return true;
            }

            return false;
        }

        delegate int Compare(int p1, string p2); //делегат

        static int CompareEq(int p1, string p2) //метод, соответствующий данному делегату
        {
            int p2i;
            if (int.TryParse(p2, out p2i))
            {
                p2i = int.Parse(p2);
                if (p1 == p2i) return 1;
                else return 0;
            }
            else
            {
                return -1;
            }
        }

        static void Write(int n, Compare comparator) // метод, принимающий разработанный делегат, в качестве одного из входным параметров.
        {
            string str;
            int res;

            Console.Write("Введите строку для сравнения: ");
            str = Console.ReadLine();
            res = comparator(n, str);

            if (res == 1)
            {
                Console.Write("Выражение верно.");
            }
            else if (res == 0)
            {
                Console.Write("Выражение неверно.");
            }
            else
            {
                Console.Write("Выражение некорректно.");
            }
        }

        static void WriteF(int n, Func<int, string, int> comparator) //метод, принимающий обобщенный делегат Func< >
        {
            string str;
            int res;

            Console.Write("Введите строку для сравнения: ");
            str = Console.ReadLine();
            res = comparator(n, str);

            if (res == 1)
            {
                Console.Write("Выражение верно.");
            }
            else if (res == 0)
            {
                Console.Write("Выражение неверно.");
            }
            else
            {
                Console.Write("Выражение некорректно.");
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Енин Александр ИУ5-34Б";
            Console.WriteLine("Часть 1: ДЕЛЕГАТЫ\n");
            int i = 7;

            Console.Write("Пример:\nЧисло для сравнения: {0}\nПередача метода в качестве параметра-делегата: \n\t", i);
            Write(i, CompareEq); //вызов метода с параметром-делегатом
            Console.Write("\nПередача лямбда-выражения в качестве параметра-делегата: \n\t");
            Write(i,
                (int p1, string p2) =>
                {
                    int p2i;
                    if (int.TryParse(p2, out p2i))
                    {
                        p2i = int.Parse(p2);
                        if (p1 == p2i) return 1;
                        else return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
                );

            Console.Write("\nИспользование в качестве параметра обобщенного делегата:\nПередача метода в качестве параметра-делегата: \n\t");
            WriteF(i, CompareEq); //вызов метода с параметром-делегатом
            Console.Write("\nПередача лямбда-выражения в качестве параметра-делегата: \n\t");
            WriteF(i,
                (int p1, string p2) =>
                {
                    int p2i;
                    if (int.TryParse(p2, out p2i))
                    {
                        p2i = int.Parse(p2);
                        if (p1 == p2i) return 1;
                        else return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
                );


            Console.WriteLine("\nЧасть 2: РЕФЛЕКСИЯ\n");

            Type t = typeof(ReflectionObserver);

            Console.WriteLine("Тип " + t.FullName + " унаследован от " + t.BaseType.FullName);
            Console.WriteLine("Пространство имен " + t.Namespace);
            Console.WriteLine("Находится в сборке " + t.AssemblyQualifiedName);

            Console.WriteLine("\nКонструкторы:");
            foreach (var x in t.GetConstructors())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nПубличные методы");
            foreach (var x in t.GetFields())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nМетоды:");
            foreach (var x in t.GetMethods())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nСвойства");
            foreach (var x in t.GetProperties())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nСвойства с атрубутами");
            foreach (var x in t.GetProperties())
            {
                object attrObj;
                if (GetPropertyAttribute(x, typeof(CustomAttribute), out attrObj))
                {
                    CustomAttribute attr = attrObj as CustomAttribute;
                    Console.WriteLine(x.Name + " - " + attr.Description);
                }
            }
            Console.WriteLine("InvokeMember");
            ReflectionObserver fi = (ReflectionObserver)t.InvokeMember(null, BindingFlags.CreateInstance, null, null, new object[] { });
            Console.WriteLine("InvokeMethod");
            object[] parameters = { 10, 5 };
            object Result = t.InvokeMember("Plus", BindingFlags.InvokeMethod, null, fi, parameters);
            Console.WriteLine("Plus(10,5)={0}", Result);

            Console.ReadLine();

        }
    }
}

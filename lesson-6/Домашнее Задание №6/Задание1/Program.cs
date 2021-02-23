#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
1. Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double,double). 
Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
*/
#endregion

#region Библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
#endregion

namespace Задание1
{
    class Program
    {
        public delegate double Fun(double a, double b);

        public static void Function(Fun f, double a, double b)
        {
            Console.Write(f(a, b));
        }

        public static double MyFunc(double a, double b)
        {
            return a * b * b;
        }

        public static double FunSin(double a, double b)
        {
            return a * Math.Sin(b);
        }

        static void Main(string[] args)
        {
            Function(FunSin, 5, 1);

            Function(MyFunc, 5, 5);

            Console.ReadKey();
        }
    }
}

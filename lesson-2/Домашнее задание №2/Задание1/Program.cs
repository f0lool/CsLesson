#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
1. Написать метод, возвращающий минимальное из трех чисел.
*/
#endregion

#region Библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Задание1
{
    class Program
    {
        static int min(int a, int b, int c)
        {
            int min = a;

            if (b < min && b < c)
                min = b;
            else if (c <= b && c < min)
                min = c;

            return min;
        }
        static void Main(string[] args)
        {
            #region Считывание данных
            int a = int.Parse(Console.ReadLine());

            int b = int.Parse(Console.ReadLine());

            int c = int.Parse(Console.ReadLine());
            #endregion

            Console.Write(min(a,b,c));

            Console.ReadKey();
        }
    }
}

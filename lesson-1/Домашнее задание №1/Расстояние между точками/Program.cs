#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
3.
а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
*/
#endregion

#region Библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Задание3
{
    class Program
    {
        #region Метод для подсчитывания расстояния между двумя точками
        static void distanceXY(double x1, double y1, double x2, double y2)
        {
            var r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.Write("Расстояние между точками равно {0:f2}", r);
        }
        #endregion
        static void Main(string[] args)
        {
            #region Считывание данных
            Console.Write("Введите координату x1: ");
            var x1 = double.Parse(Console.ReadLine());

            Console.Write("Введите координату y1: ");
            var y1 = double.Parse(Console.ReadLine());

            Console.Write("Введите координату x2: ");
            var x2 = double.Parse(Console.ReadLine());

            Console.Write("Введите координату y2: ");
            var y2 = double.Parse(Console.ReadLine());
            #endregion

            distanceXY(x1, y1, x2, y2);

            Console.ReadLine();
        }
    }
}

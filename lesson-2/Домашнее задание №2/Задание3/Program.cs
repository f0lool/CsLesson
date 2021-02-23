#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
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
        static void Main(string[] args)
        {
            int a;
            int sum = 0;
            do
            {
                a = int.Parse(Console.ReadLine());
                if (a % 2 != 0 && a > 0)
                    sum += a;
            } while (a != 0);

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}

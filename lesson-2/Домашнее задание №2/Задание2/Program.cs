#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
2. Написать метод подсчета количества цифр числа.
*/
#endregion

#region Библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Задание2
{
    class Program
    {
        public static int NumberCount(int number)
        {
            int count = 0;
            while (number > 0)
            {
                count++;
                number = number / 10;
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число в котором вы хотите посчитать количество цифр: ");
            
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Количество цифр в числе {number} равно {NumberCount(number)}");

            Console.ReadKey();
        }
    }
}

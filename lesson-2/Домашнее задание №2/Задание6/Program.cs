#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.
Хорошим называется число, которое делится на сумму своих цифр. 
Реализовать подсчет времени выполнения программы, используя структуру DateTime.
*/
#endregion

#region Библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Задание6
{
    class Program
    {
        static int SumNumber(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number = number / 10;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            var start = DateTime.Now;

            int count = 0;

            for (int i = 1; i < 1000000000; i++)
            {
                if (i % SumNumber(i) == 0)
                    count++;
            }

            Console.Write($"Количество хороших чисел: {count} \nВремя за которое отработала программа: {DateTime.Now - start}");

            Console.ReadLine();
        }
    }
}

#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
*/
#endregion

#region Библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Задание7
{
    class Program
    {
        static void Consistency(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(a);
                Consistency(a + 1, b);
            }
        }

        static int ConsistencySum(int a, int b)
        {
            if (a == b)
                return a;
            else
                return a + ConsistencySum(a + 1, b);
        }
        static void Main(string[] args)
        {
            var startNumber = 1;

            var finishNumber = 0;

            do
            {
                Console.Write("Введите число с которого начинаем: ");
                startNumber = int.Parse(Console.ReadLine());

                Console.Write("Введите число которым заканчиваем: ");
                finishNumber = int.Parse(Console.ReadLine());

                if (startNumber >= finishNumber)
                    Console.Write("Первое число не может быть больше второго. Попробуйте ещё\n");
            } while (startNumber >= finishNumber);

            Consistency(startNumber, finishNumber);

            Console.Write(ConsistencySum(startNumber, finishNumber));

            Console.ReadLine();
        }
    }
}

#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. 
При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;
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
        static void Main(string[] args)
        {
            var flag = false;
            string a;
            int x;
            var sum = 0;

            do
            {
                a = Console.ReadLine();
                if (ErrorFunction(a))
                {
                    while (ErrorFunction(a) != false)
                    {
                        Console.Write("Вы ввели некорректное значение\n");
                        a = Console.ReadLine();
                    }
                }

                flag = int.TryParse(a, out x);
                if (flag && x > 0 && x % 2 != 0)
                {
                    sum += x;
                }

            } while (x != 0);

            Console.WriteLine(sum);

            Console.ReadLine();
        }

        static bool ErrorFunction(string str)
        {
            bool flag;
            int x;

            try
            {
                flag = int.TryParse(str, out x);
                if (!flag)
                    throw new Exception();
                return false;
            } catch (Exception)
            {
                return true;
            }
        }
    }
}

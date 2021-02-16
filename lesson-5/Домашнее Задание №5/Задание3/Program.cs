#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:
б) *разработав собственный алгоритм.
Например:
badc являются перестановкой abcd.
*/
#endregion

#region Библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
#endregion

namespace Задание3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую строку: ");
            string text1 = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string text2 = Console.ReadLine();
            int count = 0;

            if (text1.Length == text2.Length)
                for (int i = 0; i < text1.Length; i++)
                    for (int j = 0; j < text2.Length; j++)
                        if (text1[i] == text2[j])
                        {
                            count++;
                            break;
                        }

            if (count == text1.Length)
                Console.WriteLine("Эти две строки являются перестановкой друг друга");
            else
                Console.WriteLine("Эти две строки не являются перестановкой друг друга");

            Console.ReadLine();
        }
    }
}

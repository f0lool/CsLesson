#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
1. Создать программу, которая будет проверять корректность ввода логина. 
Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
б) с использованием регулярных выражений.
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

namespace Задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            bool flag = false;
            Regex regex = new Regex(@"[^a-z0-9]", RegexOptions.IgnorePatternWhitespace);

            Console.Write("Придумайте логин: ");
            login = Console.ReadLine();

            while (!flag)
            {
                if (login.Length < 2 || login.Length > 10)
                {
                    Console.Write("Логин дожен быть длиной не меньше 2 и не больше 10\n");
                    login = Console.ReadLine();
                }
                if (char.IsNumber(login[0]))
                {
                    Console.Write("Логин не может начинаться с цифры\n");
                    login = Console.ReadLine();
                }
                if (regex.IsMatch(login))
                {
                    Console.Write("Логин может содеражать только латинские буквы и цифры от 0 до 9\n");
                    login = Console.ReadLine();
                }
                else
                {
                    flag = true;
                    Console.Write("Ваш логин подходит по всем критериям!!!");
                }
            }


            Console.ReadKey();
        }
    }
}

#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
5.
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) Сделать задание, только вывод организуйте в центре экрана
в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)
*/
#endregion

#region Библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Задание5
{
    class Program
    {
        static void Print(string Name, string Surname, string City, int x, int y)
        {
            Console.SetCursorPosition(x, y);

            var msg = $"Имя: {Name}  Фамилия: {Surname}  Город проживания: {City}";
            
            Console.Write(msg);
        }

        static void Main(string[] args)
        {
            #region Считывание данных
            Console.Write("Введите ваше имя: ");
            var Name = Console.ReadLine();

            Console.Write("Введите вашу фамилию: ");
            var Surname = Console.ReadLine();

            Console.Write("Введите ваш город проживания: ");
            var City = Console.ReadLine();
            #endregion

            Print(Name, Surname, City, 30, 15);

            Console.ReadLine();
        }
    }
}

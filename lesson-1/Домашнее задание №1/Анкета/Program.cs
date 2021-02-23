#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
а) используя склеивание;
б) используя форматированный вывод;
в) *используя вывод со знаком $.
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
        static void Main(string[] args)
        {
            #region Считывание данных
            Console.Write("Введите ваше имя: ");
            var name = Console.ReadLine();

            Console.Write("Введите вашу фамилию: ");
            var surname = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            var age = double.Parse(Console.ReadLine());

            Console.Write("Введите ваш рост: ");
            var growth = double.Parse(Console.ReadLine());

            Console.Write("Введите ваш вес: ");
            var weight = double.Parse(Console.ReadLine());
            #endregion

            #region Вывод информации
            Console.Write("Имя: " + Name + " Фамилия: " + Surname + " Возраст: " + Age + " Рост: " + Growth + " Вес: " + Weight + "\n");// Решение под буквой а

            Console.Write("Имя: {0} Фамилия: {1} Возраст: {2} Рост: {3} Вес: {4}", Name, Surname, Age, Growth, Weight + "\n");// Решение под буквой б

            Console.Write($"Имя: {Name} Фамилия: {Surname} Возраст: {Age} Рост: {Growth} Вес: {Weight}");// Решение под буквой в
            #endregion

            Console.ReadLine();
        }
    }
}

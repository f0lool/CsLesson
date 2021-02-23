#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
б) Используйте массив (или список) делегатов, в котором хранятся различные функции.
в) *Переделайте функцию Load, чтобы она возвращала массив считанных значений. Пусть она
возвращает минимум через параметр.
*/
#endregion

#region Библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
#endregion

namespace Задание2
{
    class Program
    {
        public delegate double Fun(double x);

        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double F2(double x)
        {
            return 2 * x + 5;
        }

        public static double F3(double x)
        {
            return x / 2;
        }

        public static void Print(double min, double[] arrayNumbers)
        {

            for (int i = 0; i < arrayNumbers.Length; i++)
                Console.WriteLine(arrayNumbers[i]);

            Console.WriteLine(min);
        }

        public static void SaveFunc(Fun f, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(f(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double[] Load(string fileName, ref double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double d;
            double[] arrayNumber = new double[fs.Length / sizeof(double)];
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = bw.ReadDouble();
                arrayNumber[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return arrayNumber;
        }
        static void Main(string[] args)
        {
            double min = double.MaxValue;
            int start;
            int finish;
            int switchNumber;

            double[] arrayNumbers;
            Fun[] massiv = new Fun[] { F, F2, F3 };

            Console.Write("Для какой функции вы хотите найти минимум?\n" +
                "1. Вида ax*x + bx + c\n" +
                "2. Вида kx + b\n" +
                "3. Вида x/2\n");

            switchNumber = int.Parse(Console.ReadLine());

            switch (switchNumber)
            {
                case 1:
                    Console.Write("Введите диапазон для поиска минимума границы:\n" +
                        "От: ");
                    start = int.Parse(Console.ReadLine());
                    Console.Write("До: ");
                    finish = int.Parse(Console.ReadLine());
                    SaveFunc(massiv[0], "data.bin", start, finish, 1);

                    arrayNumbers = Load("data.bin", ref min);

                    Print(min, arrayNumbers);
                    break;
                case 2:
                    Console.Write("Введите диапазон для поиска минимума границы:\n" +
                        "От: ");
                    start = int.Parse(Console.ReadLine());
                    Console.Write("До: ");
                    finish = int.Parse(Console.ReadLine());
                    SaveFunc(massiv[1], "data.bin", start, finish, 1);

                    arrayNumbers = Load("data.bin", ref min);

                    Print(min, arrayNumbers);
                    break;
                case 3:
                    Console.Write("Введите диапазон для поиска минимума границы:\n" +
                        "От: ");
                    start = int.Parse(Console.ReadLine());
                    Console.Write("До: ");
                    finish = int.Parse(Console.ReadLine());
                    SaveFunc(massiv[2], "data.bin", start, finish, 1);

                    arrayNumbers = Load("data.bin", ref min);

                    Print(min, arrayNumbers);
                    break;
            }

            Console.ReadKey();
        }
    }
}

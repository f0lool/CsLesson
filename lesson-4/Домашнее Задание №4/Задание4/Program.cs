#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
4. *а) Реализовать класс для работы с двумерным массивом. 
Реализовать конструктор, заполняющий массив случайными числами. 
Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива,
свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out)
*б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
Дополнительные задачи
в) Обработать возможные исключительные ситуации при работе с файлами.
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

namespace Задание4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Каким способом вы хотите иницилизировать массив:\n" +
                "1. Через файл\n" +
                "2. Через рандом\n");

            int switchNumber = int.Parse(Console.ReadLine());

            switch (switchNumber)
            {
                case 1:
                    Matrix fileArray = new Matrix(1, 1, 1, 1);
                    SwitchArray(TryCatchPathFile(fileArray, "read"));
                    break;

                case 2:
                    Console.Write("Введите количество строк: ");
                    int sizeX = int.Parse(Console.ReadLine());

                    Console.Write("Введите длину одной строки: ");
                    int sizeY = int.Parse(Console.ReadLine());

                    Console.Write("Введите минимальное значения для рандома: ");
                    int minValue = int.Parse(Console.ReadLine());

                    Console.Write("Введите максимальное значения для рандома: ");
                    int maxValue = int.Parse(Console.ReadLine());

                    Matrix myArray = new Matrix(sizeX, sizeY, minValue, maxValue);

                    SwitchArray(myArray);
                    break;

                default:
                    break;
            }
        }
        public static void SwitchArray(Matrix array)
        {
            Console.Write("Что вы хотите сделать с массивом:\n" +
                "1. Узнать максимальное значение\n" +
                "2. Узнать минимальное значение\n" +
                "3. Узнать индекс максимального значения\n" +
                "4. Узнать сумму всех элементов\n" +
                "5. Узнать сумму всех элементов болше определенного числа\n" +
                "6. Вывести массив на экран\n" +
                "7. Записать данный массим в текстовый файл\n" +
                "8. Закончить\n");

            int switchNumber = default;

            while (switchNumber != 8)
            {
                switchNumber = int.Parse(Console.ReadLine());
                switch (switchNumber)
                {
                    case 1:
                        Console.Write($"Максимальное значение равно {array.Max}\n");
                        break;
                    case 2:
                        Console.Write($"Минимальное значение равно {array.Min}\n");
                        break;
                    case 3:
                        array.IndexMax(ref array.indexXmax, ref array.indexYmax, array);
                        Console.Write($"Индекс максимального элемента равен [{array.indexXmax}] [{array.indexYmax}]\n");
                        break;
                    case 4:
                        Console.Write($"Сумма всех элементов равна {array.Sum()}\n");
                        break;
                    case 5:
                        Console.Write("Введите заданное число больше которого будут суммироваться числа: ");
                        int maxSum = int.Parse(Console.ReadLine());
                        Console.Write($"Сумма чисел в массиве больше {maxSum} равна {array.Sum(maxSum)}\n");
                        break;
                    case 6:
                        Matrix.Print(array);
                        break;
                    case 7:
                        TryCatchPathFile(array, "write");
                        break;
                    case 8:
                        break;
                }
            }

        }
        public static Matrix TryCatchPathFile(Matrix array, string writeOrRead)
        {
            string filePath = default;
            bool flag = false;
            while (!flag)
            {
                if (writeOrRead == "write")
                {
                    Console.Write("Введите путь до файла: ");
                    filePath = Console.ReadLine();
                    try
                    {
                        array.WriteFile(filePath);
                        flag = true;
                    }
                    catch (Exception)
                    {
                        Console.Write("Вы ввели некорректный путь\n");
                        flag = false;
                    }
                    return null;

                }
                else if (writeOrRead == "read")
                {
                    Console.Write("Введите путь до файла: ");
                    Matrix fileArray = new Matrix(1, 1, 1, 1);
                    filePath = Console.ReadLine();
                    try
                    {
                        fileArray = new Matrix(filePath);
                        flag = true;
                    }
                    catch (Exception)
                    {
                        Console.Write("Вы ввели некорректный путь\n");
                        flag = false;
                    }
                    return fileArray;
                }
                else
                    return null;

            }
            return null;
        }
    }
    class Matrix
    {
        public int[,] a;
        public int indexXmax = default;
        public int indexYmax = default;
        public Matrix(int sizeX, int sizeY, int minValue, int maxValue)
        {
            a = new int[sizeX, sizeY];
            Random random = new Random();
            for (int i = 0; i < sizeX; i++)
                for (int j = 0; j < sizeY; j++)
                    a[i, j] = random.Next(minValue, maxValue);
        }
        public Matrix(string filename)
        {
            StreamReader sr = new StreamReader(filename);

            int _sizeX = int.Parse(sr.ReadLine());
            int _sizeY = int.Parse(sr.ReadLine());

            a = new int[_sizeX, _sizeY];

            for (int i = 0; i < _sizeX; i++)
                for (int j = 0; j < _sizeY; j++)
                    a[i, j] = int.Parse(sr.ReadLine());

            sr.Close();
        }
        public int Min
        {
            get
            {
                var min = a[0, 0];
                foreach (int el in a)
                    if (el < min)
                        min = el;
                return min;
            }
        }
        public int Max
        {
            get
            {
                var max = a[0, 0];
                foreach (int el in a)
                    if (el > max)
                        max = el;
                return max;
            }
        }


        public int Sum()
        {
            var sum = 0;
            foreach (int el in a)
                sum += el;
            return sum;
        }
        public void IndexMax(ref int indexXMax, ref int indexYMax, Matrix array)
        {
            for (int i = 0; i < array.a.GetLength(0); i++)
                for (int j = 0; j < array.a.GetLength(1); j++)
                    if (a[i, j] == Max)
                    {
                        indexXMax = i;
                        indexYMax = j;
                    }
        }
        public static void Print(Matrix array)
        {
            for (int i = 0; i < array.a.GetLength(0); i++)
                for (int j = 0; j < array.a.GetLength(1); j++)
                {
                    Console.Write(array.a[i, j] + " ");
                    if (j == array.a.GetLength(1) - 1)
                        Console.WriteLine();
                }
        }
        public void WriteFile(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);

            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sw.Write(a[i, j] + " ");
                    if (j == a.GetLength(1) - 1)
                        sw.WriteLine();
                }
            sw.Close();
        }
        public int Sum(int minValue)
        {
            var sum = 0;
            foreach (int el in a)
                if (el > minValue)
                    sum += el;
            return sum;
        }
    }

}

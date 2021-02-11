#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
2. а) Дописать класс для работы с одномерным массивом. 
Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом. 
Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива,
метод Multi, умножающий каждый элемент массива на определенное число, свойство MaxCount, возвращающее количество максимальных элементов. 
В Main продемонстрировать работу класса.
б)Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
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
        static void Main(string[] args)
        {
            Console.Write("Каким бы способом вы хотели создать массив?\n" +
                "1.Через ввод\n" +
                "2.Через файл\n");

            int switchNumber = int.Parse(Console.ReadLine());

            switch (switchNumber)
            {
                case 1:
                    Console.Write("Какой бы длины вы хотели массив?\n");
                    int size = int.Parse(Console.ReadLine());

                    Console.Write("Какой начальный элемент в массиве?\n");
                    int start = int.Parse(Console.ReadLine());

                    Console.Write("С каким шагом идут числа?\n");
                    int step = int.Parse(Console.ReadLine());

                    MyArray newArray = new MyArray(size, start, step);

                    SwitchArray(newArray);
                    break;
                case 2:
                    MyArray fileArray = new MyArray(1, 1, 1);

                    SwitchArray(TryCatchPathFile(fileArray, "read"));
                    break;
            }
        }

        public static void SwitchArray(MyArray array)
        {
            Console.Write("Процедуры над вашим массивом:\n" +
                "1.Узнать максимальное значение\n" +
                "2.Узнать минимальное значение\n" +
                "3.Узнать количество положительных чисел\n" +
                "4.Узнать сумму всех чисел\n" +
                "5.Узнать количество чисел равных максимальному значению\n" +
                "6.Поменять знак чисел\n" +
                "7.Умножить все значения на определённое число\n" +
                "8.Вывести массив на экран\n" +
                "9.Записать массив текстовый файл\n" +
                "10.Закончить\n");

            int switchNumber = default;

            while (switchNumber != 10)
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
                        Console.Write($"Количество положительных чисел равно {array.CountPositiv}\n");
                        break;
                    case 4:
                        Console.Write($"Сумма всех чисел равна {array.Sum}\n");
                        break;
                    case 5:
                        Console.Write($"Количество чисел раных максимальному значению равно {array.MaxCount}\n");
                        break;
                    case 6:
                        array.Inverse();
                        break;
                    case 7:
                        Console.Write("Введите число на которое хотите умножить: ");
                        int multi = int.Parse(Console.ReadLine());

                        array.Multi(multi);
                        break;
                    case 8:
                        Console.Write(array + "\n");
                        break;
                    case 9:
                        TryCatchPathFile(array, "write");
                        break;
                    case 10:
                        break;
                }
            }
        }

        public static MyArray TryCatchPathFile(MyArray array, string writeOrRead)
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
                    MyArray fileArray = new MyArray(1, 1, 1);
                    Console.Write("Введите путь до файла: ");
                    filePath = Console.ReadLine();
                    try
                    {
                        fileArray = new MyArray(filePath);
                        flag = true;
                    }
                    catch (Exception)
                    {
                        Console.Write("Вы ввели некорректный путь\n");
                        flag = false;
                    }
                    return fileArray;
                }
            }
            return null;
        }
    }

}

class MyArray
{
    int[] a;

    public MyArray(int n, int el)
    {
        a = new int[n];
        for (int i = 0; i < n; i++)
            a[i] = el;
    }

    public MyArray(int size, int start, int step)
    {
        a = new int[size];
        a[0] = start;
        for (int i = 1; i < a.Length; i++)
            a[i] = a[i - 1] + step;
    }

    public MyArray(string filename)
    {
        StreamReader sr = new StreamReader(filename);
        int size = int.Parse(sr.ReadLine());
        a = new int[size];

        for (int i = 0; i < a.Length; i++)
            a[i] = int.Parse(sr.ReadLine());
        sr.Close();
    }
    public int Max
    {
        get
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
                if (a[i] > max) max = a[i];
            return max;
        }
    }
    public int Min
    {
        get
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
                if (a[i] < min) min = a[i];
            return min;
        }
    }
    public int CountPositiv
    {
        get
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] > 0) count++;
            return count;
        }
    }

    public int Sum
    {
        get
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
                sum += a[i];
            return sum;
        }
    }

    public int MaxCount
    {
        get
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == Max)
                    count++;
            }
            return count;
        }
    }

    public void Inverse()
    {
        for (int i = 0; i < a.Length; i++)
            a[i] = -a[i];
    }

    public void Multi(int multi)
    {
        for (int i = 0; i < a.Length; i++)
            a[i] = a[i] * multi;
    }
    public void ReadFile(string filename)
    {
        StreamReader sr = new StreamReader(filename);

        for (int i = 0; i < a.Length; i++)
            a[i] = int.Parse(sr.ReadLine());
        sr.Close();
    }

    public void WriteFile(string filename)
    {
        StreamWriter sw = new StreamWriter(filename);

        for (int i = 0; i < a.Length; i++)
            sw.Write(a[i] + " ");
        sw.Close();
    }
    public override string ToString()
    {
        string s = "";
        foreach (int v in a)
            s = s + v + " ";
        return s;
    }
}


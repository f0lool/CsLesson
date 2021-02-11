#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. 
В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
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
            int count = 0;
            int[] arrayNumbers = new int[20];

            for (int i = 0; i < arrayNumbers.Length; i++)
                arrayNumbers[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < arrayNumbers.Length; i++)
                if (arrayNumbers[i] % 3 == 0 || arrayNumbers[i + 1] % 3 == 0)
                    count++;

            Console.WriteLine(count);

            Console.ReadLine();
        }



    }
}

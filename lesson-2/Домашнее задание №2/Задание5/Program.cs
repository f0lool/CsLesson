#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
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

        static double BMI(double weight, double height)
        {
            var bmi = weight / (Math.Pow(height, 2));
            return bmi;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите ваш вес в кг: ");
            var weight = double.Parse(Console.ReadLine());

            Console.Write("Введите ваш рост в м: ");
            var height = double.Parse(Console.ReadLine());

            var bmi = BMI(weight, height);

            Console.WriteLine($"Ваш индекс массы тела: {bmi:f2}");

            if (bmi < 18.5)
            {
                Console.Write("Ниже нормального веса \n");

                var need = Math.Pow(height, 2) * 18.5;

                Console.Write($"Вам нужно набрать {Math.Abs(weight - need):f2} кг");

            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.Write("Нормальный вес \n");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.Write("Избыточный вес \n");
                var neddWeight = Math.Pow(height, 2) * 24.99;

                Console.Write($"Вам нужно похудеть на {Math.Abs(weight - neddWeight):f2} кг");
            }
            else if (bmi >= 30 && bmi < 35)
            {
                Console.Write("Ожирение 1 степени \n");

                var needWeight = Math.Pow(height, 2) * 24.99;

                Console.Write($"Вам нужно похудеть на {Math.Abs(weight - needWeight):f2} кг");
            }
            else if (bmi >= 35 && bmi < 40)
            {
                Console.Write("Ожирение 2 степени \n");

                var needWeight = Math.Pow(height, 2) * 24.99;

                Console.Write($"Вам нужно похудеть на {Math.Abs(weight - needWeight):f2} кг");
            }
            else if (bmi >= 40)
            {
                Console.Write("Ожирение 3 степени \n");

                var needWeight = Math.Pow(height, 2) * 24.99;

                Console.Write($"Вам нужно похудеть на {Math.Abs(weight - needWeight):f2} кг");
            }

            Console.ReadLine();
        }
    }
}

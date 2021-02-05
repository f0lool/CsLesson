#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
3. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. 
Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
Написать программу, демонстрирующую все разработанные элементы класса.
** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
ArgumentException("Знаменатель не может быть равен 0");
Добавить упрощение дробей.
*/
#endregion

#region Библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion
namespace Задание3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fractions fractionOne = new Fractions();
            Console.Write("Введите числитель первой дроби: ");
            fractionOne.Numerator = int.Parse(Console.ReadLine());
            Console.Write("Введите знаменатель первой дроби: ");
            fractionOne.Denominator = int.Parse(Console.ReadLine());

            Fractions fractionTwo = new Fractions();
            Console.Write("Введите числитель второй дроби: ");
            fractionTwo.Numerator = int.Parse(Console.ReadLine());
            Console.Write("Введите знаменатель второй дроби: ");
            fractionTwo.Denominator = int.Parse(Console.ReadLine());



            Console.Write("Что вы хотите сделать с дробями:\n" +
                "1.Сложить\n" +
                "2.Вычесть\n" +
                "3.Умножить\n" +
                "4.Разделить\n");

            var switchNumber = int.Parse(Console.ReadLine());
            var result = fractionOne.Plus(fractionTwo);

            switch (switchNumber)
            {
                case 1:
                    result = fractionOne.Plus(fractionTwo);
                    break;
                case 2:
                    result = fractionOne.Minus(fractionTwo);
                    break;
                case 3:
                    result = fractionOne.Multi(fractionTwo);
                    break;
                case 4:
                    result = fractionOne.Division(fractionTwo);
                    break;
                default:
                    Console.Write("Вы ввели некорректное значение. Ваши дроби, по умолчанию, будут сложенны");
                    break;
            }

            for (int i = 2; i <= Math.Min(result.Numerator, result.Denominator); i++)
            {
                if (result.Numerator % i == 0 && result.Denominator % i == 0)
                {
                    result.Numerator = result.Numerator / i;
                    result.Denominator = result.Denominator / i;
                }
            }

            Console.WriteLine($"{result.Numerator}/{result.Denominator} or {result.DecimalFraction:f2}");

            Console.ReadKey();
        }
    }
    class Fractions
    {
        private int numerator;
        public int Numerator
        {
            set { numerator = value; }
            get { return numerator; }
        }

        private int denominator;

        public int Denominator
        {
            set
            {
                try
                {
                    denominator = value;
                    if (denominator == 0)
                        throw new ArgumentException();
                }
                catch (ArgumentException)
                {
                    while (denominator == 0)
                    {
                        Console.Write("Знаменатель не может быть равен нулю. Введите значение отличное от нуля: ");
                        denominator = int.Parse(Console.ReadLine());
                    }
                }
            }
            get { return denominator; }
        }

        private double decimalFraction;

        public double DecimalFraction
        {
            get { return decimalFraction; }
        }
        public Fractions Plus(Fractions fractionOne)
        {
            Fractions fractionTwo = new Fractions();
            var nok = (fractionOne.denominator * denominator) / Gcd(fractionOne.denominator, denominator);

            fractionTwo.numerator = numerator * (nok / denominator) + fractionOne.numerator * (nok / fractionOne.denominator);
            fractionTwo.denominator = nok;
            fractionTwo.decimalFraction = (double)fractionTwo.numerator / fractionTwo.denominator;

            return fractionTwo;
        }

        public Fractions Minus(Fractions fractionOne)
        {
            Fractions fractionTwo = new Fractions();
            var nok = (fractionOne.denominator * denominator) / Gcd(fractionOne.denominator, denominator);

            fractionTwo.numerator = numerator * (nok / denominator) - fractionOne.numerator * (nok / fractionOne.denominator);
            fractionTwo.denominator = nok;
            fractionTwo.decimalFraction = (double)fractionTwo.numerator / fractionTwo.denominator;

            return fractionTwo;
        }

        public Fractions Multi(Fractions fractionOne)
        {
            Fractions fractionTwo = new Fractions();

            fractionTwo.numerator = numerator * fractionOne.numerator;
            fractionTwo.denominator = denominator * fractionOne.denominator;
            fractionTwo.decimalFraction = (double)fractionTwo.numerator / fractionTwo.denominator;

            return fractionTwo;
        }

        public Fractions Division(Fractions fractionOne)
        {
            Fractions fractionTwo = new Fractions();

            fractionTwo.numerator = numerator * fractionOne.denominator;
            fractionTwo.denominator = denominator * fractionOne.numerator;
            fractionTwo.decimalFraction = (double)fractionTwo.numerator / fractionTwo.denominator;

            return fractionTwo;
        }

        public int Gcd(int _a, int _b)
        {
            var a = _a;
            var b = _b;

            while (a != 0 && b != 0)
            {
                if (a > b)
                    a = a % b;
                else
                    b = b % a;
            }

            return a + b;
        }
    }
}

#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
в) Добавить диалог с использованием switch демонстрирующий работу класса.
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
            Console.Write("Чтобы вы хотели посмотреть?\n" +
                "1. Структуру комлексных чисел\n" +
                "2. Класс комплексных чисел\n");

            var switchComplex = int.Parse(Console.ReadLine());

            switch (switchComplex)
            {
                case 1:
                    ComplexS complexOne;
                    Console.Write("Введите вещественную часть первого числа: ");
                    complexOne.re = int.Parse(Console.ReadLine());
                    Console.Write("Введите мнимую часть первого числа: ");
                    complexOne.im = int.Parse(Console.ReadLine());

                    ComplexS complexTwo;
                    Console.Write("Введите вещественную часть второго числа: ");
                    complexTwo.re = int.Parse(Console.ReadLine());
                    Console.Write("Введите мнимую часть второго числа: ");
                    complexTwo.im = int.Parse(Console.ReadLine());

                    Console.Write("Что вы хотите сделать с этими числами?\n" +
                        "1. Сложить\n" +
                        "2. Вычесть\n" +
                        "3. Умножить\n");

                    var switchOperator = int.Parse(Console.ReadLine());
                    ComplexS result;

                    switch (switchOperator)
                    {
                        case 1:
                            result = complexOne.Plus(complexTwo);
                            break;
                        case 2:
                            result = complexOne.Minus(complexTwo);
                            break;
                        case 3:
                            result = complexOne.Multi(complexTwo);
                            break;
                        default:
                            result.re = 0;
                            result.im = 0;
                            break;
                    }

                    Console.Write($"{result.re} + {result.im}i");
                    break;
                case 2:
                    Complex complexFirst = new Complex();
                    Console.Write("Введите вещественную часть первого числа: ");
                    complexFirst.Re = double.Parse(Console.ReadLine());
                    Console.Write("Введите мнимую часть первого числа: ");
                    complexFirst.Im = double.Parse(Console.ReadLine());

                    Complex complexSecond = new Complex();
                    Console.Write("Введите вещественную часть второго числа: ");
                    complexSecond.Re = double.Parse(Console.ReadLine());
                    Console.Write("Введите мнимую часть второго числа: ");
                    complexSecond.Im = double.Parse(Console.ReadLine());

                    Console.Write("Что вы хотите сделать с этими числами?\n" +
                        "1. Сложить\n" +
                        "2. Вычесть\n" +
                        "3. Умножить\n");

                    switchOperator = int.Parse(Console.ReadLine());
                    Complex resultClass = new Complex();

                    switch (switchOperator)
                    {
                        case 1:
                            resultClass = complexFirst.Plus(complexSecond);
                            break;
                        case 2:
                            resultClass = complexFirst.Minus(complexSecond);
                            break;
                        case 3:
                            resultClass = complexFirst.Multi(complexSecond);
                            break;
                        default:
                            break;
                    }

                    Console.Write($"{resultClass.Re} + {resultClass.Im}i");
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }

    class Complex
    {
        private double im;
        double re;

        public Complex()
        {
            im = 0;
            re = 0;
        }

        public Complex(double _im, double re)
        {
            im = _im;
            this.re = re;
        }
        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

        public Complex Multi(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = re * x2.im + im * x2.re;
            x3.re = re * x2.re - im * x2.im;

            return x3;
        }

        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = im - x2.im;
            x3.re = re - x2.re;

            return x3;
        }
        public double Im
        {
            get { return im; }
            set
            {
                if (value >= 0) im = value;
            }
        }

        public double Re
        {
            get { return re; }
            set
            {
                if (value >= 0) re = value;
            }
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    struct ComplexS
    {
        public double im;
        public double re;
        public ComplexS Plus(ComplexS x)
        {
            ComplexS y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        public ComplexS Multi(ComplexS x)
        {
            ComplexS y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }

        public ComplexS Minus(ComplexS x2)
        {
            ComplexS x3;
            x3.im = im - x2.im;
            x3.re = re - x2.re;

            return x3;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }

}



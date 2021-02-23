#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
С помощью цикла do while ограничить ввод пароля тремя попытками.
*/
#endregion

#region Библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Задание4
{
    class Program
    {
        static bool CheckData(string password, string login)
        {
            if (password == "root" && login == "GeekBrains")
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            var check = false;
            var login = "None";
            var password = "None";
            var count = 0;

            do
            {
                count++;
                Console.Write("Введите логин: ");
                login = Console.ReadLine();

                Console.Write("Введите пароль: ");
                password = Console.ReadLine();

                check = CheckData(password, login);

                if (count == 3 && check == false)
                    Console.WriteLine("Вы 3 раза ввели неверный пароль или логин. У вас больше нет попыток");

            } while (!check && count < 3);

            if (check == true)
                Console.Write("Вы успешно авторизовались!");

            Console.ReadLine();
        }
    }
}

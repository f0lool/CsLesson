#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
3. Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив. 
Создайте структуру Account, содержащую Login и Password.
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

namespace Задание3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            int count = 0;

            StreamReader streamReaderLogins = new StreamReader(@"C:\Users\user\Desktop\logins.txt");
            StreamReader streamReaderPasswords = new StreamReader(@"C:\Users\user\Desktop\passwords.txt");

            List<Account> accounts = new List<Account>();

            while (!streamReaderLogins.EndOfStream && !streamReaderPasswords.EndOfStream)
            {
                Account acc;
                acc._login = streamReaderLogins.ReadLine();
                acc._password = streamReaderPasswords.ReadLine();
                accounts.Add(acc);
            }

            do
            {
                Console.Write("Введите ваш логин: ");
                string Login = Console.ReadLine();
                Console.Write("Введите ваш пароль: ");
                string Password = Console.ReadLine();
                count++;

                for (int i = 0; i < accounts.Count; i++)
                {
                    flag = accounts[i].CheckData(Login, Password);
                    if (flag)
                        break;
                }
                if (flag)
                    Console.WriteLine($"Вы успешно авторизовались как {Login}");
                else
                    Console.WriteLine($"Вы ввели неправильный логин или пароль. Попробуйте ещё раз");

            } while (!flag && count < 3);

            Console.ReadKey();
        }
    }

    struct Account
    {
        public string _login;
        public string _password;


        public bool CheckData(string login, string password)
        {
            if (_login == login && _password == password)
                return true;
            else
                return false;
        }

    }
}

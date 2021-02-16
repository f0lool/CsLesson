#region Автор
// Червов Алексей
#endregion

#region Описание задания
/*
5. **Написать игру «Верю. Не верю». В файле хранятся вопрос и ответ, правда это или нет. 
Например: «Шариковую ручку изобрели в древнем Египте», «Да». Компьютер загружает эти данные, случайным образом выбирает 5 вопросов и задаёт их игроку. 
Игрок отвечает Да или Нет на каждый вопрос и набирает баллы за каждый правильный ответ. Список вопросов ищите во вложении или воспользуйтесь интернетом.
*/
#endregion

#region Библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
#endregion

namespace Задание5
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathQuestions = @"C:\Users\user\source\repos\Домашнее Задание №5\Задание5\questions.txt";
            string pathAnswer = @"C:\Users\user\source\repos\Домашнее Задание №5\Задание5\answer.txt";
            int score = 0;
            string answer;
            Random random = new Random();
            int count;

            List<GameInfo> gameInfo = new List<GameInfo>();

            GameInfo.Read(pathQuestions, pathAnswer, gameInfo);

            for (int i = 0; i < 5; i++)
            {
                count = random.Next(1, gameInfo.Count());
                Console.WriteLine(gameInfo[count].question);
                answer = Console.ReadLine();
                if (answer.ToLower() == gameInfo[count].answer.ToLower())
                {
                    score++;
                    Console.WriteLine("Верно");
                    gameInfo.RemoveAt(count);
                }
                else
                {
                    Console.WriteLine("Не верно");
                    gameInfo.RemoveAt(count);
                }
                Console.WriteLine($"Ваше количество баллов: {score}");
            }

            Console.ReadKey();
        }
    }
    class GameInfo
    {
        public string question;
        public string answer;

        public static void Read(string pathQuestion, string pathAnswer, List<GameInfo> gameInfo)
        {
            StreamReader streamReaderQ = new StreamReader(pathQuestion);
            StreamReader streamReaderA = new StreamReader(pathAnswer);

            while (!streamReaderQ.EndOfStream && !streamReaderA.EndOfStream)
            {
                GameInfo info = new GameInfo();
                info.question = streamReaderQ.ReadLine();
                info.answer = streamReaderA.ReadLine();

                gameInfo.Add(info);
            }

            streamReaderA.Close();
            streamReaderQ.Close();
        }
    }
}


using System;
using System.Collections.Generic;

namespace Diary
{
    class Program
    {
        public static List<DateList> Catalogs = new List<DateList>() {
            new DateList(new DateTime(2022, 9, 11), new List<Page>() {
                new Page("Сдать C#", "Задачи: Сдать до 23:59"),
                new Page("Сдать историю", "Задачи: Сделать доклад по культуре СССР")
            }),
            new DateList(new DateTime(2022, 10, 11), new List<Page>() {
                new Page("Не проспать первую пару", "Задачи: Лечь не в 1 ночи, а в 22:30"),
                new Page("Сдать психологию общения", "Задачи: Рассказать доклад")
            }),
            new DateList(new DateTime(2022, 11, 11), new List<Page>() {
                new Page("Сегодня пятница, можно и пиво выпить", "Задачи: Открыть и насладиться пивом "),
                new Page("Начать отдыхать","Задачи: Какой отдыхать иди питон делай!!!")

            })
        };
        public static int ActiveList = 0;

        static void Main(string[] args)
        {
            Catalogs[ActiveList].Open();
        }
        public static void setCursor(int start, int next)
        {
            Console.SetCursorPosition(0, start + next);
            Console.WriteLine("->");
        }
        public static void setBind(ConsoleKey button, int max, int next)
        {
            if (button == ConsoleKey.UpArrow)
            {
                if (next == 0) Catalogs[ActiveList].ActiveList = max;
                else Catalogs[ActiveList].ActiveList -= 1;
            }
            else if (button == ConsoleKey.DownArrow)
            {
                if (next == max) Catalogs[ActiveList].ActiveList = 0;
                else Catalogs[ActiveList].ActiveList += 1;
            }
            else if (button == ConsoleKey.LeftArrow)
            {
                max = Catalogs.Count - 1;
                if (ActiveList == 0) ActiveList = max;
                else ActiveList--;
            }
            else if (button == ConsoleKey.RightArrow)
            {
                max = Catalogs.Count - 1;
                if (ActiveList == max) ActiveList = 0;
                else ActiveList++;
            }
        }
    }
}
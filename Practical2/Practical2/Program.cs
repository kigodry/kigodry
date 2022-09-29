using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : Угадайте число");
            Console.WriteLine("2 : Таблица умножения");
            Console.WriteLine("3 : Вывод делителей числа");
            Console.WriteLine("4 : Выход из программы");

            while (true)
            {
                Console.WriteLine("Какую программу желаете выбрать?");
                int action = Convert.ToInt32(Console.ReadLine());

                switch (action)
                {
                    case 1:

                        Random random = new Random();
                        int randomNumber = random.Next(0, 100);
                        int guess;
                        int numberOfGuess = 3;
                        bool gameOver = false;
                       
                        Console.WriteLine("Я загадал число от 0 до 100. Угадаете?");

                        while (gameOver == false)
                        {
                            guess = Convert.ToInt32(Console.ReadLine());
                            numberOfGuess--;

                            if (guess != randomNumber && numberOfGuess == 0)
                            {
                                Console.WriteLine("К сожалению,вы проиграли!");
                                gameOver = true;
                            }
                            else if (guess == randomNumber)
                            {
                                Console.WriteLine("Поздравляю,вы победили!");
                                gameOver = true;
                            }
                            else if (guess > randomNumber)
                                Console.WriteLine("Меньше");
                            else if (guess < randomNumber)
                                Console.WriteLine("Больше");
                        }
                        break;

                     case 2:
                        {
                            for (int x = 1; x <=10; x++)
                            {
                                for (int y = 1; y <=10; y++)
                                {
                                    Console.Write("{0}x{1}={2}\t",y,x,x*y); 
                                }
                                Console.WriteLine();
                            }
                            break ;
                        }
                      case 3:
                        Console.WriteLine("Введите число ниже");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= n; i++)
                        {
                            if (n % i == 0)
                                Console.Write(i + " ");
                        }
                        Console.WriteLine();
                        break;

                    case 4:
                        {
                            Console.WriteLine("До свидания!");
                            Environment.Exit(0);
                            break;
                        }
                        
                }
            }
        }
    }
}
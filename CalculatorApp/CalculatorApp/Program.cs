using System;
using System.Security.Cryptography.X509Certificates;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;
                

                Console.WriteLine("-----------------");
                Console.WriteLine("Калькулятор");
                Console.WriteLine("-----------------");

                Console.Write("Выберите число 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Выберите число 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("\t1 : Сложение");
                Console.WriteLine("\t2 : Вычитание");
                Console.WriteLine("\t3 : Умножение");
                Console.WriteLine("\t4 : Деление");
                Console.WriteLine("\t5 : Возведение в степень");
                Console.WriteLine("\t6 : Квадратный корень");
                Console.WriteLine("\t7 : Процент от числа");
                /*Console.WriteLine("\t8 : Факториал числа");*/
                Console.WriteLine("Введите вариант: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        result = num1 + num2;
                        Console.WriteLine($"Вашь результат: {num1} + {num2} = " + result);
                        break;
                    case "2":
                        result = num1 - num2;
                        Console.WriteLine($"Вашь результат: {num1} - {num2} = " + result);
                        break;
                    case "3":
                        result = num1 * num2;
                        Console.WriteLine($"Вашь результат: {num1} * {num2} = " + result);
                        break;
                    case "4":
                        result = num1 / num2;
                        Console.WriteLine($"Вашь результат: {num1} / {num2} = " + result);
                        break;
                    case "5":
                        result = Math.Pow(num1,num2);
                        Console.WriteLine($"Вашь результат: {num1} ^ {num2} = " + result);
                        break;
                    case "6":
                        result = Math.Sqrt(num1);
                        Console.WriteLine($"Вашь результат: {num1} = " + result);
                        break;
                    case "7":
                        result = num1 / 100;
                        Console.WriteLine($"Вашь результат: {num1} / {100} = " + result);
                        break;
                    /*case "8":
                        result = num1 / 100;
                        Console.WriteLine($"Вашь результат: {num1} / {100} = " + result);*/
                    default:
                        Console.WriteLine("Ошибка ввода!");
                        break;
                }
                Console.WriteLine("Хотите продолжить? (Y = да, N = нет): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Спасибо за использование. До свидания!");
            Console.ReadKey();
        }
    }
}
using System;

namespace Pianino
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Актавы: F1,F2,F3");
            Console.WriteLine("Клавиши Черные: Q,W,E,R,T");
            Console.WriteLine("Клавиши Белые: Z,X,C,V,B,N,M");

            int[] firstOctave = { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
            while (true)
            {
                ConsoleKeyInfo InfoPain;
                InfoPain = Console.ReadKey(true);
                switch (InfoPain.Key)
                {
                    case ConsoleKey.F1:
                        Console.WriteLine("Актава - 1");
                        firstOctave = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
                        break;
                    case ConsoleKey.F2:
                        Console.WriteLine("Актава - 2");
                        firstOctave = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
                        break;
                    case ConsoleKey.F3:
                        Console.WriteLine("Актава - 3");
                        firstOctave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
                        break;
                    
                    case ConsoleKey.Q:
                        Console.Beep(firstOctave[0], 250);
                        break;
                    case ConsoleKey.W:
                        Console.Beep(firstOctave[1], 250);
                        break;
                    case ConsoleKey.E:
                        Console.Beep(firstOctave[2], 250);
                        break;
                    case ConsoleKey.R:
                        Console.Beep(firstOctave[3], 250);
                        break;
                    case ConsoleKey.T:
                        Console.Beep(firstOctave[4], 250);
                        break;
                    case ConsoleKey.Z:
                        Console.Beep(firstOctave[5], 250);
                        break;
                    case ConsoleKey.X:
                        Console.Beep(firstOctave[6], 250);
                        break;
                    case ConsoleKey.C:
                        Console.Beep(firstOctave[7], 250);
                        break;
                    case ConsoleKey.V:
                        Console.Beep(firstOctave[8], 250);
                        break;
                    case ConsoleKey.B:
                        Console.Beep(firstOctave[9], 250);
                        break;
                    case ConsoleKey.N:
                        Console.Beep(firstOctave[10], 250);
                        break;
                    case ConsoleKey.M:
                        Console.Beep(firstOctave[11], 250);
                        break;
                }
            }
        }
    }
}
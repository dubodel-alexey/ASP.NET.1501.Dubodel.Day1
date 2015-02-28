using System;
using logic;

namespace ConsoleUI
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Введите число");
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Неверный ввод");
                Console.WriteLine("Введите число");
            }

            Console.WriteLine("Введите степень");
            int power;
            while (!int.TryParse(Console.ReadLine(), out power))
            {
                Console.WriteLine("Неверный ввод");
                Console.WriteLine("Введите степень");
            }

            Console.WriteLine("root({0}, {1})  Newton method: {2}", number, power, Mathematic.GetRoot(number, power));
            double pow = (power == 0) ? 0 : 1.0/power;
            Console.WriteLine("Math.Pow({0}, {1}): {2}", number, power, Math.Pow(number, pow));
            Console.ReadKey();
        }
    }
}

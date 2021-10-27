using System;

namespace Домашняя_работа
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();
            Console.WriteLine($"Привет,{name}, сегодня " + DateTime.Now); // Основное задание

            string[] m = new string[100]; // Дополнительное задание
            for (int i = 1; i < m.Length; i++)
            {
                m[i] = i.ToString();
                if (i % 3 == 0)
                {
                    m[i] = "fizz";
                }
                if (i % 5 == 0)
                {
                    m[i] = "buzz";
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    m[i] = "fizzbuzz";
                }
                Console.WriteLine(m[i]);
            }
        }
    }
}

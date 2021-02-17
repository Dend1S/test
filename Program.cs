using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            string numer = Console.ReadLine();
            foreach (char number in numer)
            {
                Console.Write(Convert.ToInt32(numer.Contains('5')));
            }
        }
    }
}
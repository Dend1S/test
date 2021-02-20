using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine()) ;
            int b = Convert.ToInt32(a/10);
            Console.Write($"{b * (++b)}" + "25");
        }
    }
}

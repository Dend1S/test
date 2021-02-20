using System;

namespace Task_336
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int max = 0;
            int min = 0;
            min = max = 0;
            int curr = 0;
            char first_char = input[0];
            foreach (char i in input)
            {
                if (i == first_char)

                {

                    curr++;
                }


                else

                {

                    curr--;
                }


                if (max < curr)

                {

                    max = curr;

                }

                if (min > curr)
                {

                    min = curr;

                }

                Console.WriteLine(max - min + 1);

                //Крч я старался но союз распался
                //P.s Не работает





            }
        }
    }
}
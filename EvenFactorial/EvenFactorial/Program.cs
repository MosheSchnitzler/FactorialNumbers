using System;

namespace EvenFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number from 3 to 65");
            var input = Console.ReadLine();
            ulong num = Convert.ToUInt64(input);
            ulong results = num;
            if (results > 2 && results < 66)
            {
                while (num > 2)
                {
                    num--;
                    results *= num;
                }
                Console.WriteLine($"The results is {results}.");
            }
            else
            {
                Console.WriteLine("You can only enter a number from 3 to 66");
            }

        }
    }
}
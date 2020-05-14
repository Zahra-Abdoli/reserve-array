using System;

namespace Reserve_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = new int[5];

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"enter your number {i + 1}:");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
            
            for (int i=4; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadKey();
            }
            catch { Console.WriteLine("invalid input"); }
        }
    }
}

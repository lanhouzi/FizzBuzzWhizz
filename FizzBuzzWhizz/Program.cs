using System;
using System.Linq;

namespace FizzBuzzWhizz
{
    class Program
    {
        static void Main(string[] args)
        {
            Output(Console.ReadLine());
            Console.ReadLine();
        }
        static void Output(string recive)
        {
            int[] Input = recive.Split(',').Select(i => Convert.ToInt32(i)).ToArray();
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i.ToString().Contains(Input[0].ToString()) ? "Fizz" : (0 != i % Input[0] && 0 != i % Input[1] && 0 != i % Input[2]) ? i.ToString() : (0 == i % Input[0] ? "Fizz" : "") + (0 == i % Input[1] ? "Buzz" : "") + (0 == i % Input[2] ? "Whizz" : ""));
            }
        }
    }
}

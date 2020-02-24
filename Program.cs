using System;

namespace learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;


            Console.WriteLine("age:  ");
            string text = Console.ReadLine();
            int a = Convert.ToInt32(text);
            if (a < 18)
            {
                Console.WriteLine("too young");
            }
            else
            {
                Console.WriteLine("too oldsds");
            }
            Console.ReadKey();
        }
    }
}

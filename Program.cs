using System;

namespace Methods_Pelky_Annalesa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please ener a whole number!");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another whole number!");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Multiplay(x,y));

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            WelcomeUser(name);

            GoodBye();
        }

        static int Multiplay(int num1, int num2)
        {
            return num1 * num2;
        }

        static void WelcomeUser(string username)
        {
            Console.WriteLine($"Hello, {username}! It is nice to meet you!");
        }
        // <summary>
        // Prints a good bye message to the console
        // </summary>
        static void GoodBye()
        {
            Console.WriteLine("Have a fantastic day!");
        }
    }
}

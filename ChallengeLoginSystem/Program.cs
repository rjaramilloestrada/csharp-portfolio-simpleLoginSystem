using System;

namespace ChallengeLoginSystem
{
    internal class Program
    {
        // universal variables 

        static string username; 
        static string password; 
        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }

        public static void Register()
        {
            Console.WriteLine("Welcome.\nPlease enter your username: ");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your password: ");
            password = Console.ReadLine();
            Console.WriteLine("Thank you.\nRegistration has been completed.");
            Console.WriteLine("--------------------------------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username: ");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password: ");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login Successful");
                }
                else
                {
                    Console.WriteLine("Login failed, wrong password. Please, restart the program");
                }
            }
            else
            {
                Console.WriteLine("Login failed, wrong username. Plase, restart the program");
            }
        }
    }
}

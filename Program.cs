using System.Security.Cryptography.X509Certificates;

namespace User_Input_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part1();
        }

        public static void Part1()
        {
            string usersName;
            int usersAge;
            Console.Write("Hello! Whhats your name? ");
            Console.Write("");
            usersName = Console.ReadLine();
            Console.WriteLine("Oh nice to meet you " + usersName + ", my name is Kenzie!");


        }
    }
}

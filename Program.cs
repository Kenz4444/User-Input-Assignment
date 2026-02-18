using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace User_Input_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Part1();
            Part2();   
        }

        public static void Part1()
        {
            string usersName;
            int usersAge;
            double moneyMade;
            Console.Write("Hello! Whats your name? ");
            Console.Write("");
            usersName = Console.ReadLine();
            Console.WriteLine("Oh nice to meet you " + usersName + ", my name is Kenzie!");
            Console.Write("How old are you?");
            Console.Write(" ");
            int.TryParse(Console.ReadLine(), out usersAge);
            Console.Write("Oh wow! " + usersAge + " Isnt that old at all! How much do you make " + usersName + "?");
            Console.Write(" ");
            double.TryParse(Console.ReadLine(), out moneyMade);
            Console.WriteLine("WOW! " + moneyMade.ToString("C") + " I hope thats per hour and not per year!");

            
        }
        public static void Part2() 
        {
            string firstName;
            string lastName;
            int grade;
            int studentId;
            string studentLogin;
            double studentAverage;
            Console.WriteLine("Please enter the following information");
            Console.Write("First name: ");
            Console.Write("");
            firstName = Console.ReadLine();
            Console.Write("Last name: ");
            Console.Write("");
            lastName = Console.ReadLine();
            Console.Write("Grade (9-12): ");
            Console.Write("");
            int.TryParse(Console.ReadLine(), out grade);
            Console.Write("Student login: ");
            Console.Write(" ");
            int.TryParse(Console.ReadLine(), out studentId);
            Console.Write("Login: ");
            Console.Write("");
            studentLogin = Console.ReadLine();
            Console.Write("Average: ");
            Console.Write("");
            double.TryParse(Console.ReadLine(), out studentAverage);





        }
    } 
}

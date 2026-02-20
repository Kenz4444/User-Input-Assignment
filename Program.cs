using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace User_Input_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Part1();
            //Part2();
            //Part3();
            Part4();
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
            int id;
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
            Console.WriteLine("Your information:");
            Console.WriteLine("\tID: \t\t" + studentId);
            Console.WriteLine("\tLogin: \t\t" + studentLogin);
            Console.WriteLine("\tName: \t\t" + lastName + (", ") + firstName);
            Console.WriteLine("\tGrade: \t\t" + grade);
            Console.WriteLine("\tAverage: \t" + studentAverage);


        }
        public static void Part3()
        {
            string firstName;
            int age;
            Console.Write("Hello what is your name? ");
            Console.Write(" ");
            firstName = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Hey " + firstName + ("! How old are you?"));
            Console.Write(" ");
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("");
            Console.WriteLine("Did you know in five years you will be " + (age + 5) + (" years old? And five years ago you were ") + (age - 5) + (" years old?"));


        }
        public static void Part4()
        {
            double numberOne;
            double numberTwo;
            double numberThree;
            Console.Write("Hello friend! will you give me three numbers?");
            Console.WriteLine("");
            Console.Write("Number one: ");
            Console.Write("");
            double.TryParse(Console.ReadLine(), out numberOne);
            Console.Write("Number two: ");
            Console.Write("");
            double.TryParse(Console.ReadLine(), out numberTwo);
            Console.Write("Number three: ");
            Console.Write("");
            double.TryParse(Console.ReadLine(), out numberThree);


        }
    }   

        
}

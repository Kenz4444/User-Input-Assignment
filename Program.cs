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
            //Part4();
            Part5();
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
            double numbersTotal;
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
            Console.Write("");
            numbersTotal = (numberOne + numberTwo + numberThree) / 2 ;
            Console.WriteLine("Cool! this is all those numbers added and divided by two: " + numbersTotal);



        }
        public static void Part5()
        {
            string itemOne;
            double priceOne;
            string itemTwo;
            double priceTwo;
            double total;
            double discount;
            double subtotal;
            
            
            Console.WriteLine("Hey friend! would you share the names and prices of two items for me?");

            Console.WriteLine("What is your first item?");
            itemOne = Console.ReadLine();
            Console.Write("How much did it cost? $");
            double.TryParse(Console.ReadLine(), out priceOne);


            Console.WriteLine("What is your second item?");
            itemTwo = Console.ReadLine();
            Console.Write("How much did it cost? $");
            double.TryParse(Console.ReadLine(), out priceOne);


            // Input done...Generate receipt

            Console.WriteLine("Sales Reciept");
            Console.Write("");
            Console.Write("Item one: " + itemOne);
            Console.Write("");
            
            Console.Write("Price: " + priceOne.ToString("C");
            Console.Write("");
            double.TryParse(Console.ReadLine(), out priceOne);
            Console.Write("Item two: ");
            Console.Write("");
            itemTwo = Console.ReadLine();
            Console.Write("Price: ");
            double.TryParse(Console.ReadLine(), out priceTwo);
            
            Console.WriteLine("---------------------");
            total = (priceOne + priceTwo);
            Console.WriteLine("Total: " + total.ToString("C"));
            discount = (total * 0.2);
            Console.WriteLine("Discount (20%): " + discount.ToString("C"));
            subtotal = (total - discount);
            Console.WriteLine("Subtotal: " + subtotal.ToString("C")); 
            




           

        }
    }   

        
}

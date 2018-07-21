using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (Exception)
            {
                Console.WriteLine("Format exception, please enter the correct type next time.");
            }

            //Console.ReadKey;

            string input = Console.ReadLine();
            Console.WriteLine(input);

            Console.WriteLine(Adding());

            WriteSomething();
            WriteSomethingSpecific("this is input for WriteSomethingSpecific");

            Console.WriteLine(Add(5, 8));
            Console.WriteLine(Multiply(5, 8));
            Console.WriteLine(divide(5, 8));

            Console.WriteLine(myFriend("Steven"));

            Console.Read();
        }

        //access modifier (static) return type method name (paramter1, parameter2)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from WriteSomthing method");
            //Console.Read();
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
            //Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double divide(double num1, double num2)
        {
            return num1 / num2;
        }

        //Challenge
        public static string myFriend(string friend)
        {
            return "Hello " + friend + ", my friend!";
        }

        public static int Adding()
        {
            Console.WriteLine("Let's add some numbers.  please enter an integer (a number with no decimals)");
            string num1 = Console.ReadLine();
            Console.WriteLine("Great!  no enter a second number.");
            string num2 = Console.ReadLine();
            int sum = Int32.Parse(num1) + Int32.Parse(num2);
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);
            return sum;
        }
    }
}

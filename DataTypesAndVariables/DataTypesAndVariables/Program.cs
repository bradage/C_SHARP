using System;

namespace DataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ints
            int num1 = 13;
            int num2 = 17;
            int sum = num1 + num2;

            //Doubles
            double d1 = 3.5;
            double d2 = 1.337;
            double sumD = d1 + d2;

            //Floats
            float f1 = 3.5f;
            float f2 = 6.5f;
            float sumF = f1 + f2;


            Console.WriteLine("num1 is " + num1);
            Console.WriteLine("num2 is " + num2);
            Console.WriteLine("the sum of num1 and num2 is " + sum);
            Console.WriteLine("The sum of " + d1 + " and + " + d2 + " is " + sumD);
            Console.WriteLine("The sum of " + f1 + " and + " + f2 + " is " + sumF);

            //Strings
            string myName = "Bradey";
            string message = "My name is ";
            string printOut = message + myName;

            Console.WriteLine(printOut.ToUpper());

            //strings in need of parsing
            string myString = "15";
            string mySecondString = "13";
            string result = myString + mySecondString;

            //parsing to int
            int numst1 = Int32.Parse(myString);
            int numst2 = Int32.Parse(mySecondString);
            int resultInt = numst1 + numst2;


            Console.WriteLine(result);
            Console.WriteLine(resultInt);

            //Constants
            const double PI = 3.14159265359;
            const int weeks = 52, months = 12;

            const string dob = "7/19/1985";

            Console.WriteLine("My brthday is always going to be: {0}", dob);



            Console.Read();

        }
    }
}

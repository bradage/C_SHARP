using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Changing the text color in console
            Console.ForegroundColor = ConsoleColor.Blue;
            //change the color of the background
            Console.BackgroundColor = ConsoleColor.DarkGray;
            //applies color to whole window
            Console.Clear();
            Console.WriteLine("Hello World");
            Console.WriteLine("Testing github sync");
            Console.Read();

            

        }
    }
}

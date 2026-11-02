
using System;

namespace CSharpLearning
{
    enum Colors : sbyte
    {
        Red = 1,
        Green,
        Blue,
        Black
    }
    class EnumInCSharp
    {
        static void Main()
        {
            Console.WriteLine("Please select a color:");
            Console.WriteLine("1. Red");
            Console.WriteLine("2. Green");
            Console.WriteLine("3. Blue");
            Console.WriteLine("4. Black");
            bool isValidChoice = int.TryParse(Console.ReadLine(), out int choice);
            Colors userChoice = (Colors)choice;

            if (isValidChoice)
            {
                if (userChoice == Colors.Red)
                {
                    Console.WriteLine("You selected Red.");
                }
                else if (userChoice == Colors.Green)
                {
                    Console.WriteLine("You selected Green.");
                }
                else if (userChoice == Colors.Blue)
                {
                    Console.WriteLine("You selected Blue.");
                }
                else if (userChoice == Colors.Black)
                {
                    Console.WriteLine("You selected Black.");
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
            else
                Console.WriteLine("Invalid user input.");

        }
    }
}

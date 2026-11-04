
using System;

namespace CSharpLearning
{
    class Program
    {
        static string GetNumberToText(int userInput)
        {
            string[] numbersInText = { "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth", "Tenth" };
            return numbersInText[userInput - 1];
        }

        static int[] FillTheData(int userInput)
        {
            int[] values = new int[userInput];
            for (int i = 1; i <= userInput; i++)
            {
                Console.WriteLine("Please enter " + GetNumberToText(i) + " number:");
                values[i - 1] = Convert.ToInt32(Console.ReadLine());
            }
            return values;
        }
        static int GetMaxNumber(int userInput)//1-10
        {
           
            int[] values= FillTheData(userInput);
            int maxNumber = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > maxNumber)
                {
                    maxNumber = values[i];
                }
            }

            return maxNumber;
        }
        static void Main()
        {
            Console.WriteLine("Please enter the no between 1 to 10.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput >= 1 && userInput <= 10)
            {
                int maxNumber = GetMaxNumber(userInput);
                Console.WriteLine("The maximum number is: " + maxNumber);
            }
            else            
                Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");            
        }
    }
}

//google
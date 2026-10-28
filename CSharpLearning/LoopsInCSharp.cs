using System;

namespace MyNamespace
{
    using System;
    class MyClass
    {
        static void Main()
        {
            //Loops in C#
            //1. While Loop
            //2. Do While Loop
            //3. For Loop
            //4. For Each Loop


            //While,Do While, For
            //1-Assignment
            //2-Condition
            //3-Increment or Decrement - Infinite Loop


            //1.While Loop
            //int number = 5; //Assignment
            //int facatorial = 1;
            //while (number > 0)//5>0 //Condition
            //{
            //    Console.WriteLine(number);
            //    facatorial *= number;
            //    number--;//Decrement    
            //}

            //Console.WriteLine(facatorial);
            //Console.WriteLine("5*4*3*2*1=120");


            //2. Do While Loop

            //int number = 0;
            //int facatorial = 1;
            //Console.WriteLine("Please enter  a number for factorial:");
            //bool isConverionValid = int.TryParse(Console.ReadLine(),out number);

            //if (isConverionValid)
            //{
            //    do
            //    {
            //        facatorial *= number;
            //        number--;
            //    }
            //    while (number > 0);

            //    Console.WriteLine(facatorial);
            //}
            //else
            //    Console.WriteLine("Conversion failed.");


            //3. For Loop

            //G Occured 2 times.
            //o Occured 2 times.

            //string userInput = "", duplicateChars = string.Empty;
            //Console.WriteLine("Please enter a word:");//Google //0-G,1-o,2-o,3-g,4-l,5-e
            //userInput = Console.ReadLine().ToLower();            
            //int charCouter = 0;           

            //if (userInput.Length > 0)
            //{
            //    for (int i = 0; i < userInput.Length; i++)//g o o g l e
            //    {
            //        //Console.WriteLine(userInput[i]);
            //        //Console.WriteLine("-----------------------------");
            //        if (!duplicateChars.Contains(userInput[i].ToString()))
            //        {
            //            for (int j = 0; j < userInput.Length; j++)//g-google, o-google
            //            {
            //                //Console.WriteLine(userInput[j]);
            //                if (userInput[i] == userInput[j])
            //                {
            //                    charCouter++;
            //                }
            //            }
            //            if (charCouter > 1)
            //            {
            //                duplicateChars += userInput[i];
            //                Console.WriteLine($"Character '{userInput[i]}' occurred {charCouter} times.");
            //            }
            //            charCouter = 0;
            //        }                                     
            //    }
            //}


            //4. For Each Loop

            string value = "Divil";

            //foreach (char c in value)//Forward Iteration
            //{
            //    Console.WriteLine(c);
            //}              

            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("-----------------------");
            for (int n = numbers.Length-1; n >= 0; n--) 
            {
                Console.WriteLine(numbers[n]);
            }

            int [] values = { 22, 33, 66, 11, 50 };


        }

    }

}
namespace MyNamespace
{
    using System;
    class MyClass
    {
        static void Main()
        {
            //Control Flow in C#
            //If-Else Statement
            //Switch Statement


            //If else 

            //if(true)            
            //    Console.WriteLine("This is true");            
            //else            
            //    Console.WriteLine("This is false");            

            //Console.WriteLine("Please enter a first number");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());//1//"1"//1


            //Console.WriteLine("Please enter a second number");
            //int secondNumber = Convert.ToInt32(Console.ReadLine());//1//"1"//1


            //Console.WriteLine("Please enter a third number");
            //int thirdNumber = Convert.ToInt32(Console.ReadLine());//1//"1"//1

            //if(firstNumber> secondNumber && firstNumber > thirdNumber)            
            //    Console.WriteLine("First number is the largest");            
            //else if (secondNumber > firstNumber && secondNumber > thirdNumber)            
            //    Console.WriteLine("Second number is the largest");            
            //else            
            //    Console.WriteLine("Third number is the largest");            

            //Console.WriteLine("Please enter a number between 1 to 10");
            //int userInput = Convert.ToInt32(Console.ReadLine());

            //if (userInput == 1)
            //    Console.WriteLine("1");
            //else if (userInput == 2)
            //    Console.WriteLine("2");
            //else if (userInput == 3)
            //    Console.WriteLine("3");
            //else if (userInput == 4)
            //    Console.WriteLine("4");
            //else if (userInput == 5)
            //    Console.WriteLine("5");
            //else if (userInput == 6)
            //    Console.WriteLine("6");
            //else if (userInput == 7)
            //    Console.WriteLine("7");
            //else if (userInput == 8)
            //    Console.WriteLine("8");
            //else if (userInput == 9)
            //    Console.WriteLine("9");
            //else
            //    Console.WriteLine("Other value");

            //Console.WriteLine("Please enter your name");
            //string userInput = Console.ReadLine();//Suresh


            //if(userInput == "Suresh")
            //{
            //    Console.WriteLine("Hello, Suresh!");
            //    Console.WriteLine("Please enter your city");
            //    string userCity = Console.ReadLine();
            //    if(userCity =="Noida")
            //        Console.WriteLine("You live in Noida!");
            //}                
            //else
            //    Console.WriteLine("Hello, Guest!");


            //switch (switch_on)
            //{
            //    default:
            //}

            Console.WriteLine("Please enter a number between 1 to 10");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == 1)
                Console.WriteLine("1");
            else if (userInput == 2)
                Console.WriteLine("2");
            else if (userInput == 3)
                Console.WriteLine("3");
            else if (userInput == 4)
                Console.WriteLine("4");
            else if (userInput == 5)
                Console.WriteLine("5");
            else if (userInput == 6)
                Console.WriteLine("6");
            else if (userInput == 7)
                Console.WriteLine("7");
            else if (userInput == 8)
                Console.WriteLine("8");
            else if (userInput == 9)
                Console.WriteLine("9");
            else
                Console.WriteLine("Other value");

            switch (userInput)
            {
                case 1:                
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                case 4:
                    Console.WriteLine("4");
                    break;
                case 5:
                    Console.WriteLine("5");
                    break;
                case 6:
                    Console.WriteLine("6");
                    break;
                case 7:
                    Console.WriteLine("7");
                    break;
                case 8:
                    Console.WriteLine("8");
                    break;
                case 9:
                    Console.WriteLine("9");
                    goto case 1;
                default:
                    Console.WriteLine("Other value");
                    break;
            }

        }
    }

}
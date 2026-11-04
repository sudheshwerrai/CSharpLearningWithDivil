
using System;

namespace CSharpLearning
{
    class AgeValidationException : Exception
    {
        public AgeValidationException(string message) : base(message)
        {
            
        }
    }
    class ExceptionHandling
    {
        static void Main()
        {

            int age = 17;

            try
            {
                if (age < 18)
                {
                    throw new AgeValidationException("Age should be greater than 18.");
                }
                else
                {
                    Console.WriteLine("You are eligible for voting.");
                }
            }
            catch (AgeValidationException ex)
            {

                Console.WriteLine(ex.Message);
            }
            

            //int i = 10;


            //int[] values = new int[1];//0 1 2
            ////values[1] = 10;

            //try
            //{
            //    //int result = i / 0;
            //    values[1] = 10;
            //    Console.WriteLine("If error occured I will be not executed");
            //    //
            //}

            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Message:" + ex.Message + " StackTrace:" + ex.StackTrace
            //        + " InnerException:" + ex.InnerException
            //        + " Source:" + ex.Source);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Message:" + ex.Message + " StackTrace:" + ex.StackTrace
            //        + " InnerException:" + ex.InnerException
            //        + " Source:" + ex.Source);
            //}
            //catch (Exception ex) 
            //{
            //    //Console.WriteLine("We are facing some technical issues. Try after some times.");
            //    Console.WriteLine("Message:" + ex.Message + " StackTrace:" + ex.StackTrace
            //        + " InnerException:" + ex.InnerException
            //        + " Source:" + ex.Source);
            //    //Console.WriteLine("An error occurred.");
            //}

            //finally 
            //{
            //    Console.WriteLine("Finally block will be always executed.");
            //}
        }
    }
}

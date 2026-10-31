

using System;
using CalculatorDLL;

namespace CSharpLearning.MethodTypes
{
   static class Program
    {

        //Extension Method
        //1-Class must be static.-Done
        //2-Method must be static.-Done
        //3-Method parameter must be passed this keyword a long with the type which type will access
        //this method.-Done

        //static string MakeFirstLetterCapital(this string val)
        //{
        //    if (val.Length > 0)
        //    {
        //        return val.Substring(0, 1).ToUpper() + val.Substring(1, val.Length - 1).ToLower();
        //    }
        //    return "Not a valid value found";
        //}

        static int Div(this Calculator calc, int x, int y)
        {
            return x / y;
        }
        static void Main()
        {
            //string name = "divil";
            //string result = name.MakeFirstLetterCapital();
            //Console.WriteLine(result);

            var obj = new Calculator();
            //var program = new Program();
            Console.WriteLine("Addition is:" + obj.Add(20, 10));
            Console.WriteLine("Subsctraction is:" + obj.Sub(20, 10));
            Console.WriteLine("Multiplication is:" + obj.Mul(20, 10));
            Console.WriteLine("Division is:" + obj.Div(20, 10));

        }
    }
}

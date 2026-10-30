

using System;

namespace CSharpLearning.MethodTypes
{
    static class Program
    {

        //Extension Method
        //1-Class must be static.-Done
        //2-Method must be static.-Done
        //3-Method parameter must be passed this keyword a long with the type which type will access
        //this method.-Done

        static string MakeFirstLetterCapital(this string val)
        {
            if (val.Length > 0)
            {
                return val.Substring(0, 1).ToUpper() + val.Substring(1, val.Length - 1).ToLower();
            }
            return "Not a valid value found";
        }
        static void Main()
        {
            string name = "divil";
            string result = name.MakeFirstLetterCapital();
            Console.WriteLine(result);
        }
    }
}

using System;
using System.Text;

namespace MyNamespace
{
    class MyClass
    {
        static void Main()
        {
            //String VS StringBuilder
            //String is immutable, so every time you change the value of a string, a new string object is created in memory.
            //StringBuilder is mutable, so you can change the value of a StringBuilder object without creating a new object in memory.

            string name = "Divil";
            name = "Suresh";
            name = "Dinesh";
            Console.WriteLine(name);

            var stringBuilder = new StringBuilder();
            stringBuilder.Append("Divil");
            stringBuilder.Append(" Suresh");
            stringBuilder.Append(" Dinesh");
            Console.WriteLine(stringBuilder.ToString());
        }
    }

}
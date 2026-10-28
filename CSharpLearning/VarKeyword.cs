using System.Collections;
using System;

namespace MyNamespace
{
    class MyClass
    {
        //Var Keyword in C#
        int i;
       // i = 10;
            double j = 10.5;
        char k = 'A';
        bool l = true;
        string m = "Hello World";
        object n = null;

        //var o = new MyClass();

        //int Test(var i)
        //{
        //    var p = 10;
        //    return p;
        //}

        static void Main()
        {
            var list = new ArrayList();
            list.Add(10);
            list.Add(20.5);
            list.Add('A');
            list.Add(true);
            list.Add("Hello World");
            list.Add(null);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

}
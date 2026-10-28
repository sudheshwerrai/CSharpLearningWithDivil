

using System;

namespace MyNamespace
{
    class MyClass
    {
        int number;//Value Type
        string name;//Reference Type

        static void Main()
        {
            MyClass obj = new MyClass();
            Console.WriteLine(obj.number);
            Console.WriteLine("----------------------------");
            Console.WriteLine(obj.name);
            Console.WriteLine("----------------------------");

            //Data Types in C#
            //1. Value Types
            //2. Reference Types


            //Pre-Define or Built-in Data Types in C#
            //int,double,char,bool,string,object,etc.

            //User-Defined Data Types in C#
            //class,struct,enum,interface,delegate,etc.

            //Value Types:-
            //int,dobule,char,bool,enum,struct,etc.
            //It has defulat value 0.
            //It is stored in stack memory.
            //No GC is required for value types.

            //Reference Types:-
            //string,object,class,interface,delegate,etc.
            //It has default value null.
            //It is stored in heap memory but reference is stored in stack memory.
            //GC is required for reference types.

            int i = 10;
            double d = 10.5;
            char c = 'a';
            bool b = true;
            string s = "Hello World";
            object o = 10.5;

        }
    }
}
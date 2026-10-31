using System;

namespace CSharpLearning.ConstructorInCSharp
{
    class ConstructorInCSharp
    {
        int number;
        string name;

        //Constructor in C#
        //1-Default Or Parameterless Constructor
        //2-Parameterized Or Overload Constructor
        //3-Static Constructor
        //4-Copy Constructor
        //5-Private Constructor

        public ConstructorInCSharp()
        {
            Console.WriteLine("I am a parameterless constructor");
            number = 100;
            name = "Divil";
        }

        static ConstructorInCSharp()
        {
            Console.WriteLine("I am a Static Constructor");
        }
        public ConstructorInCSharp(int num,string name)
        {
            number = num;
        }

        public ConstructorInCSharp(string name, int num)
        {

        }

        public ConstructorInCSharp(ConstructorInCSharp obj)
        {
            number = obj.number;
            name = obj.name;
        }

        void Test()
        {
            Console.WriteLine("I am a method-"+ number);
        }

        static void Main()
        {
            Console.WriteLine("I am Main Method");
            var objFirst = new ConstructorInCSharp();
            Console.WriteLine(objFirst.number);
            Console.WriteLine(objFirst.name);
            var objSecond = new ConstructorInCSharp(objFirst);
            //objSecond = objFirst;
            Console.WriteLine("-------------------------");
            Console.WriteLine(objSecond.number);
            Console.WriteLine(objSecond.name);
            //obj.Test();
            //Console.WriteLine();
        }
    }
}


using System;

namespace CSharpLearning
{
    //sealed class ABC
    //{
    //}
    class ABC
    {
    }
    class StaticVariable : ABC
    {
        int nonStaticNumber = 0;
        static int staticNumber = 0;

        public void FirstMethod()
        {
            nonStaticNumber++;
            staticNumber++;
            Console.WriteLine("First Method:" + nonStaticNumber);//1
            Console.WriteLine("First Method:" + staticNumber);//1
        }

        public void SecondMethod()
        {
            nonStaticNumber++;
            staticNumber++;
            Console.WriteLine("Second Method:" + nonStaticNumber);//1//2//
            Console.WriteLine("Second Method:" + staticNumber);//2
        }

        public static void ThirdMethod()
        {
            var obj = new StaticVariable();
            obj.nonStaticNumber++;
            staticNumber++;
            Console.WriteLine("Third Method:" + obj.nonStaticNumber);//1
            Console.WriteLine("Third Method:" + staticNumber);//3
        }
        static void Main()
        {
            var obj = new StaticVariable();
            obj.FirstMethod();
            obj.SecondMethod();
            ThirdMethod();
        }
    }
}

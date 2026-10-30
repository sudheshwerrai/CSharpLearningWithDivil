
using System;

namespace CSharpLearning.MethodTypes.PartialTypes
{
    partial class PartialType
    {
        partial void FirstMethod();
        partial void SecondMethod();
        partial void ThirdMethod();

        partial void FirstMethod()
        {
            Console.WriteLine("This is the first method");
        }
        static void Main()
        {
            var obj = new PartialType();
            obj.FirstMethod();
            obj.SecondMethod();
            obj.ThirdMethod();
        }

    }
}

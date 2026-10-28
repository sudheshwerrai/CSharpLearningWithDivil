using System;

namespace MyNamespace
{
    class Abc
    { }
    class MyClass
    {
        const double pi = 3.14159;
        readonly double e = 2.71828;
        private readonly Abc abc = null;
        string normalValue= null;
        public MyClass()
        {
            //pi = 3.14; // This will cause a compile-time error because 'pi' is a constant and cannot be modified.
            e = pi;
            abc = new Abc();
        }
        static void Test()
        {
            //pi = 3.15; // This will cause a compile-time error because 'pi' is a constant and cannot be modified.
            //e = 2.71828; // This will cause a compile-time error because 'e' is a readonly field and cannot be modified.
            //abc = new Abc(); // This will cause a compile-time error because 'abc' is a readonly field and cannot be modified outside of the constructor.
            //var obj = new MyClass();
            //obj.normalValue = "Hello, World!";
            //normalValue = "Hello, World!"; // This is allowed because 'normalValue' is a regular field and can be modified.
            Console.WriteLine(pi);          
        }
        static void Main()
        {

        }
    }

}


using System;
namespace CSharpLearning
{
    class MyClass
    {
        //Fields Or Class level variable - Static VS Non-Static
        public static int staticField = 10; // Static field
        public int nonStaticField = 20; // Non-static field

        //Properties - Static VS Non-Static
        public static int StaticProperty { get; set; } //Static Property
        public int NonStaticProperty { get; set; } //Non-Static Property

        //Methods - Static VS Non-Static
        public static void StaticMethod()
        {
            Console.WriteLine("This is a static method.");
        }
        public void NonStaticMethod()
        {
            Console.WriteLine("This is a non-static method.");
        }

       
    }
    class Normal
    {
        static void Main()
        {
            //Static VS Non-Static
            //India(Class)(Static)                              USA
            //Shri Narendra Modi(object)(Non-Static)            Donald Trump(object)(Non-Static)

            //Syntax to create a object of a class
            //ClassName objectName = new ClassName();
            MyClass obj = new MyClass(); //Creating an object of MyClass            
            
        }
    }
}

using System;
namespace MyNamespace
{
    class MyClass
    {
        string name; //2.Field or Class Level Variable

        void GreetingMessage(string message="") //3.Parameter or Parameterized Variable
        {            
            Console.WriteLine("Hello " + message +" "+ name);
        }
        static void Main()
        {

            //Variable Types in C#
            //1. Local Varible
            //2. Field OR Class Level Variable
            //3. Parameter or Parameterized Variable

            string localVariable = "Hello"; //1. Local Variable
            MyClass obj = new MyClass();
            obj.GreetingMessage("Alice"); //3. Parameter or Parameterized Variable

            int temp=0;
            Console.WriteLine(temp);
        }
    }

}
using System;

namespace MyNamespace
{
    //Abstract Method-
    //1-Whenever you will create a abstract method then that class must be abstract.-Done
    //2-It does not mean that if class is abstract then method will be also abstract there.-Done
    //3-Because abstract class can contain abstract as well as well non-abstract method (static,non-static,virtual).-Done
    //4-Abstract method should not be private.-Done
    //5-Abstract method will not contain the body.-Done
    //6-So when you will inherit this abstract class with other class there you will have to implement all the
    //abstract methods.-Done
    //7-You can't not create the instance of abstract class.-Done

    abstract class AbstractClass
    {
        public abstract void FirstAbstractMethod();
        public static void SecondStaticMethod() 
        {
            Console.WriteLine("Second Static Method from Abstract Class");
        }
        public void ThirdNonStaticMethod() 
        {
            Console.WriteLine("Third Non Static Method from Abstract Class");
        }

        public virtual void FourtVirtualMethod() 
        {
            Console.WriteLine("Fourth Virtual Method from Abstract Class");
        }

        public abstract int FifthAbstractMethod();

    }

    class Program: AbstractClass
    {
        public override void FirstAbstractMethod()
        {
            Console.WriteLine("First Implemented Abstract method");
        }
        public override int FifthAbstractMethod()
        {
            Console.WriteLine("Fifth Implemented Abstract method");
            return 0;
        }        
       
        static void Main()
        {
            var obj = new Program();
            obj.FirstAbstractMethod();
            SecondStaticMethod();
            obj.ThirdNonStaticMethod();
            obj.FourtVirtualMethod();
            obj.FifthAbstractMethod();
        }

       
    }

}
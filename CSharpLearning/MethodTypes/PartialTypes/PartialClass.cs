using System;

namespace PartialMethodExample
{
    interface IBird
    {
        void Chirping();
        void Run();
    }

    interface IAnimal
    {
        void Hunting();
        void Walking();
    }

    partial class Program : IBird
    {
        public void Chirping()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }

    partial class Program : IAnimal
    {
        public void Hunting()
        {
            throw new NotImplementedException();
        }

        public void Walking()
        {
            throw new NotImplementedException();
        }
    }

    partial class Program 
    {
        static void Main()
        {
            Console.WriteLine("Hello World");
        }       
    }

}
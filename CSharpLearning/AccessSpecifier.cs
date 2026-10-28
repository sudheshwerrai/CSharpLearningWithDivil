using CalculatorDLL;
using System;

namespace MyNamespace
{
    class MyClass //Default - Internal
    {

        public string publicField = "Public Field";
        private string privateField = "Private Field";
        protected string protectedField = "Procted Field";
        internal string internalField = "Internal Field";
        protected internal string protectedInternalField = "Protected Internal Field";


        public string PublicMethod()
        {
            return publicField;
        }

        private string PrivateMethod()
        {
            return privateField;
        }

        protected string ProtectedMethod()
        {
            return protectedField;
        }

        internal string InternalMethod()
        {
            return internalField;
        }

        protected internal string ProtectedInternalMethod()
        {
            return protectedInternalField;
        }
    }

    class Normal: Calculator
    {
        static void Main() //Default -Private
        {
            //Access Specifier in C#
            //1-Public
            //2-Private
            //3-Protected
            //4-Internal
            //5-Protected Internal

            var obj = new MyClass();
            var normal = new Normal();
            //normal.prot

            var objCalc = new Calculator();
            Console.WriteLine(objCalc.Add(30,10));
            Console.WriteLine(normal.Div(30, 10));
            
        }
    }

}

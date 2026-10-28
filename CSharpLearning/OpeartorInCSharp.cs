using System;

namespace MyNamespace
{
    class MyClass
    {
        static void Main()
        {
            //Opeartor in C# - 
            //Operators are special symbols that perform operations on variables and values.
            //C# provides a rich set of operators to perform various operations.
            //Operator Types in C#:
            //1. Arithmetic Operators +, -, *, /, %
            //2. Assignment Operators =, +=, -=, *=, /=, %=
            //3. Unary Operators ++, --
            //4. Comparison Operators ==, !=, >, <, >=, <=
            //5. Logical Operators &&, ||, !
            //6. Ternary Operators ? :


            Console.WriteLine("------------------Arithmetic Operators--------------------------");
            //1. Arithmetic Operators
            int a = 10, b = 20;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            Console.WriteLine("------------------Assignment Operators--------------------------");

            //2. Assignment Operators 
            int c = 30;
            Console.WriteLine(c);

            Console.WriteLine("------------------Unary Operators--------------------------");

            //3. Unary Operators (Pre-increment ++i and Post-increment i++) (Pre-decrement --i and Post-decrement i--)
            int d = 40;
            d--; //40
            --d; //39-1=38
            d++; //38+1
            ++d; //39+1=40
            Console.WriteLine(++d); // Pre-increment 41
            Console.WriteLine(d--); // Post-decrement 41
            Console.WriteLine(d);//40

            Console.WriteLine("------------------Comparison Operators--------------------------");
            //4. Comparison Operators
            int e = 50, f = 60;
            Console.WriteLine(e == f);//false
            Console.WriteLine(e != f);//true
            Console.WriteLine(e > f);//false
            Console.WriteLine(e < f);//true
            Console.WriteLine(e >= f);//false
            Console.WriteLine(e <= f);//true

            Console.WriteLine("------------------Logical Operators--------------------------");
            //5. Logical Operators
            bool g = true, h = false;
            Console.WriteLine(g && h);//false
            Console.WriteLine(g || h);//true
            Console.WriteLine(!g);//false

            Console.WriteLine("------------------Ternary Operators--------------------------");
            //6. Ternary Operators
            int i = 10, j = 20;
            Console.WriteLine(i > j ? i : j);//20

        }
    }

}
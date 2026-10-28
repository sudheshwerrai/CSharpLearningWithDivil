using System;

namespace MyNamespace
{
    class MyClass
    {
        static void Main()
        {
            //Imlicit & Explicit Conversion

            //Implicit Conversion:-
            //1-When you will convert lower precision value into higher precision value
            //then it is called Implicit Conversion.
            //2-Implicit Conversion is done by compiler automatically. No type casting is required.
            //3-No data loss will occur in Implicit Conversion.

            //int,short,byte


            //int
            //MaxValue = 2147483647;
            //MinValue = -2147483648;

            //short
            //MaxValue = 32767;
            //MinValue = -32768;

            //byte 
            //MaxValue = 255;
            //MinValue = 0;


            byte i = 250;
            short j = i; //Implicit Conversion
            Console.WriteLine("I values:"+i);
            Console.WriteLine("J values:"+j);
            //Explicit Conversion
            //1-When you will convert higher precision value into lower precision value
            //then it is called Explicit Conversion.
            //2-Explicit Conversion is done by programmer manually. Type casting is used for Explicit Conversion.
            //3-Data loss may occur in Explicit Conversion.

            short k = 20000;
            byte l = (byte)k; //Explicit Conversion
            Console.WriteLine("K values:"+k);
            Console.WriteLine("L values:"+l);
        }
    }

}
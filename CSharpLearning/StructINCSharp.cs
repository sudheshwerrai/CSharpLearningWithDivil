using System;

namespace CSharpLearning
{
    struct StructINCSharp
    {
        int number;

        public StructINCSharp(int number)
        {
            this.number = number;
        }
        void Test()
        {
            Console.WriteLine("I am test method");
        }
        static void Main()
        {
            //Class VS Struct
            //1-Class is reference type and Struct is value type.
            //2-Class is stored in heap memory and Struct is stored in stack memory.
            //3-All predefine value types are struct and all predefine reference types are class.
            //4-Struct can not have default constructor and destructor but class can have.
            //5-Struct can not have inheritance but class can have.
            //6-If you want to store small amount of data then use struct otherwise use class.
            //7-Struct performance is better than class because struct is stored in stack memory and class is stored in heap memory.

            StructINCSharp obj = new StructINCSharp();
            //obj.number = 123;
            //obj.Test();


            //int,double,char,bool-Struct
            //string,object-Class
        }
    }
}



//How many numbers you want to enter? Tell me the range between 1 to 10, and I will tell you the max number.
//5
//Please enter first number,

//10- Numbers, 22,11,44,33,

using System;

namespace CSharpLearning
{
    class MethodParameters
    {
        //Method Parameters
        //1-Pass by Value
        //2-Pass by Reference
        //3-Pass By Out
        //4-Pass By Params

        //1-Pass by Value
        int PassByValue(int a, int b)
        {
            a = a + 10;//a=10+10=20
            b = b + 10;//b=20+10=30
            return a + b;//20+30=50
        }

        //2-Pass by Reference
        int PassByReference(ref int a, ref int b)
        {
            a = a + 10;//a=10+10=20
            b = b + 10;//b=20+10=30
            return a + b;//20+30=50
        }

        //3-Pass By Out
        int PassByOut(int i, int j, out int a, out int b)
        {
            a = 100 + i;//a=100+10=110
            b = 200 + j;//b=200+20=220
            return a + b + i + j;//110+220+10+20=360
        }

        //4-Pass By Params

        int PassByParams(string name, params int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        int GetSum(int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        int AddNumbers(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }


        static void Main()
        {
            int i = 10, j = 20;


            //Console.WriteLine("----------------Pass By Value-----------------");
            //var passByValue = new MethodParameters();
            //int passByValueRes = passByValue.PassByValue(i, j);//50
            //Console.WriteLine(passByValueRes);
            //Console.WriteLine(i);//10
            //Console.WriteLine(j);//20

            //Console.WriteLine("----------------Pass By Ref-----------------");
            //var passByReference = new MethodParameters();
            //int passByReferenceRes = passByReference.PassByReference(ref i, ref j);//50
            //Console.WriteLine(passByReferenceRes);
            //Console.WriteLine(i);//20
            //Console.WriteLine(j);//30

            //Console.WriteLine("----------------Pass By Out-----------------");
            //var passByOut = new MethodParameters();
            //int passByOutRes = passByOut.PassByOut(i, j, out int a, out int b);
            //Console.WriteLine(passByOutRes);//360
            //Console.WriteLine(a);//110
            //Console.WriteLine(b);//220

            Console.WriteLine("----------------Pass By Params-----------------");
            var passByParams = new MethodParameters();
            int addNumbersResult = passByParams.PassByParams("",10, 20, 30);
            int getSumResult = passByParams.PassByParams("", new int[] { 10, 20, 30, 40 });
            Console.WriteLine($"Add Numbers Result: {addNumbersResult}");
            Console.WriteLine($"Get Sum Result: {getSumResult}");
        }
    }
}

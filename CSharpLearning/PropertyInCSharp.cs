
using System;

namespace CSharpLearning
{
    class Program
    {
        int number;
        //public void SetNumber(int num)//Set Accessor 
        //{
        //    number = num;
        //}
        //public int GetNumber()//Get Accessor 
        //{
        //    return number;
        //}
        public int GetSetNumber 
        {
            get //Get Accessor //Read Only Property
            {
                return number;
            }
            set //Set Accessor //Write Only Property
            { 
                number = value;
            }
        }

    }
    class Normal
    {
        static void Main()
        {
            var obj = new Program();
            //obj.SetNumber(50);
            //int number= obj.GetNumber();
            obj.GetSetNumber = 100;
            int number = obj.GetSetNumber;
            Console.WriteLine(number);
        }
    }
}

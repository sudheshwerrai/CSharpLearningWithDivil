using System;

namespace MyNamespace
{
    class Company
    {
        public virtual void Policy()
        {
            Console.WriteLine("Default Policy");
        }
    }

    class HR : Company
    {
        public override void Policy()
        {
            Console.WriteLine("Changed Policy");
        }
    }

    class Finance : Company
    {
        // void Poilcy()
        //{
        //    Console.WriteLine("Default Policy");
        //}
    }

    class IT : Company
    {
        //void Poilcy()
        //{
        //    Console.WriteLine("Default Policy");
        //}
    }

    class Sales : Company
    {
        public override void Policy()
        {
            Console.WriteLine("Changed Policy");
        }
    }
    class Program
    {
        static void Main()
        {
            //Virtual Method

            var fin = new Finance();
            fin.Policy();

            var it = new IT();
            it.Policy();

            var hr = new HR();
            hr.Policy();

            var sales = new Sales();
            sales.Policy();
        }
    }

}
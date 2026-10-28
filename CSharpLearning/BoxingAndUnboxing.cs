namespace MyNamespace
{
    class MyClass
    {
        static void Main()
        {
            //Boxing & Unboxing in C#:-
            //Boxing :
            //1-It is the process of converting a value type to the object that is called boxing.
            //2-It is implicit conversion. No Type casting is required.

            int i = 123;
            object j = i;//Boxing


            //Unboxing :
            //1-It is the process of converting the same object type to a value type that is called unboxing.
            //2-It is explicit conversion. Type casting is required.

            int k = (int)j;//Unboxing

        }
    }

}
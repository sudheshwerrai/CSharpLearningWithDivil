
using System;

namespace StaticVSNonStaticMethod
{
    class Student
    {
        // Data types and access specifiers
        public string name;
        private int marks;
        protected string Grade;        

        // const: value cannot be changed
        public const int TotalSubjects = 3;

        // readonly: value can be assigned during declaration
        // or inside a constructor
        public readonly int PassingMarks;

        // Static field
        public static int StudentCount = 0;

        // Constructor
        public Student(string name, int marks)
        {
            this.name = name;
            this.marks = marks;
            PassingMarks = 40;
            StudentCount++;            
        }

        // Non-static method
        public void DisplayStudent()
        {
            Console.WriteLine("\nStudent Name: " + name);
            Console.WriteLine("Marks: " + marks);
            Console.WriteLine("Passing Marks: " + PassingMarks);

            // if-else condition
            if (marks >= PassingMarks)
            {
                Grade = "Pass";
            }
            else
            {
                Grade = "Fail";
            }

            Console.WriteLine("Result: " + Grade);
        }

        // Static method
        public static void DisplayStudentCount()
        {
            Console.WriteLine(
                "\nTotal Students: " + StudentCount);
        }

        // Non-static method using a loop
        public void DisplaySubjectMarks()
        {
            Console.WriteLine("\nSubject Marks:");

            for (int i = 1; i <= TotalSubjects; i++)
            {
                Console.WriteLine("Subject " + i);
            }
        }

        // Operator overloading
        public static Student operator +(Student s1, Student s2)
        {
            return new Student(
                s1.name + " & " + s2.name,
                s1.marks + s2.marks);
        }
    }

    class Program
    {
        // Static method
        static void DisplayMessage()
        {
            Console.WriteLine("Student Result Management");
        }

        // Non-static method
        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the C# Console App!");
        }

        static void Main()
        {
            // Calling a static method using the class name
            DisplayMessage();

            // Creating an object to call a non-static method
            var program = new Program();
            program.DisplayWelcome();

            // Implicit conversion: int to double
            int number = 100;
            double convertedNumber = number;

            Console.WriteLine(
                "\nImplicit Conversion: " + convertedNumber);

            // Explicit conversion: double to int
            double price = 125.75;
            int convertedPrice = (int)price;

            Console.WriteLine(
                "Explicit Conversion: " + convertedPrice);

            // Creating objects
            var s1 = new Student("Rahul", 80);
            var s2 = new Student("Priya", 90);

            // Calling non-static methods
            s1.DisplayStudent();
            s1.DisplaySubjectMarks();

            s2.DisplayStudent();

            // Calling static method using class name
            Student.DisplayStudentCount();

            // Using overloaded + operator
            var s3 = s1 + s2;

            Console.WriteLine("\nCombined Student Information:");
            s3.DisplayStudent();

            // Static method called again
            Student.DisplayStudentCount();
        }
    }
}

//static class StaticClass
//{
//    //Fields
//    static int staticNum;
//    //int nonStaticNum;

//    //Properties
//    public static int StaticProp { get; set; }
//    //public int NonStaticProp { get; set; }

//    //Methods
//    public static void GetStaticValue() { }
//    //public void GetNonStaticValue() { }
//}
//class NonStaticClass
//{
//    //Fields
//    static int staticNum;
//    int nonStaticNum;

//    //Properties
//    public static int StaticProp { get; set; }
//    public int NonStaticProp { get; set; }

//    //Methods
//    public static void GetStaticValue() { }
//    public void GetNonStaticValue() { }

//}

//class Normal: NonStaticClass
//{
//    static void Main()    
//    {
//        var obj = new NonStaticClass();
//        //var newObj = new StaticClass();
//    }
//}


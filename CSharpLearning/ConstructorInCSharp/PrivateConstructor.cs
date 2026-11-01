
namespace CSharpLearning.ConstructorInCSharp
{
    class PrivateConstructor
    {
        static void Main()
        {
            var teacher = SingletonPattern.GetInstance;
            teacher.PrintMessage("Hello from teacher!");

            var student = SingletonPattern.GetInstance;
            student.PrintMessage("Hello from student!");

        }
    }
}

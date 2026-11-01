
using System;
namespace CSharpLearning.ConstructorInCSharp
{
    class SingletonPattern
    {
        private static int instanceCount = 0;

        private static SingletonPattern instance = null;
        public static SingletonPattern GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new SingletonPattern();
                return instance;
            }
        }
        private SingletonPattern()
        {
            instanceCount++;
            Console.WriteLine($"Instance created. Total instances: {instanceCount}");
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}


using System.Collections.Generic;

namespace CSharpLearning
{
    interface IStudent
    {        
        List<Student> GetDetails();       
        Student GetStudent(int id);
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
    }
    class Student : IStudent
    {
        public void AddStudent(Student student)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteStudent(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Student> GetDetails()
        {
            throw new System.NotImplementedException();
        }

        public Student GetStudent(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateStudent(Student student)
        {
            throw new System.NotImplementedException();
        }
    }
    class Program
    {
        static void Main()
        {

        }
    }
}

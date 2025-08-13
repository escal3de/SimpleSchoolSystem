using System;

namespace ConsoleApp2
{
    internal class Student
    {
        public string FirstName;
        public string LastName;
        public int Id;

        public Student(string firstName, string lastName, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }
    }
}

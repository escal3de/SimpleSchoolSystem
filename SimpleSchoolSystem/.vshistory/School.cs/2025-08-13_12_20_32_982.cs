using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class School
    {
        public string SchoolName;
        public List<Student> Students;

        public School(string name)
        {
            SchoolName = name;
            Students = new List<Student>();
        }

        int idForStudent = 1;
        public void AddStudent(string firstName, string lastName)
        {
            Students.Add(new Student(firstName, lastName, idForStudent));
            Console.WriteLine($"Ученик {firstName} был добавлен в школу {SchoolName}");
            idForStudent++;
        }

        public void RemoveStudent(int id)
        {
            Students.RemoveAt(id - 1);
            Console.WriteLine($"Ученик с идентификатором ({id}) был исключен из школы {SchoolName}");
        }

        public void ShowStudents()
        {
            if (Students.Count != 0)
            {
                Console.WriteLine("{0, -10} {1, -10} {2, -10}", "Ид.", "Имя", "Фамилия");
                for (int i = 0; i < Students.Count; i++)
                {
                    Console.WriteLine("{0, -10} {1, -10} {2, -10}", Students[i].Id, Students[i].FirstName, Students[i].LastName);
                }
            }

            else
            {
                Console.WriteLine($"Список учеников школы {SchoolName} пуст.");
            }
        }
    }
}

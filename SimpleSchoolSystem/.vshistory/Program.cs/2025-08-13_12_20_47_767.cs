using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("--- Напишите название школы ---\n" +
                ">>> ");
            string schoolName = Console.ReadLine();

            School school = new School(schoolName);
            Console.WriteLine($"Школа с именем {school.SchoolName} успешно создана!");

            bool isRun = true;

            while (isRun)
            {
                Console.Clear();
                Console.Write($"--- Выберите действия для школы {school.SchoolName} ---\n" +
                    $"Команды: список, добавить, удалить, выход:\n" +
                    $">>> ");
                string choice = Console.ReadLine();

                Console.Clear();
                Console.WriteLine($">>> {choice}");

                switch (choice)
                {
                    case "список":
                        Console.WriteLine($"--- Список учеников школы {school.SchoolName} ---");
                        school.ShowStudents();
                        break;

                    case "добавить":
                        {
                            Console.Write("--- Введите имя ученика ---\n" +
                                ">>> ");
                            string studentName = Console.ReadLine().Trim();

                            Console.Write("--- Введите фамилию ученика ---\n" +
                                ">>> ");
                            string studentLastName = Console.ReadLine().Trim();

                            school.AddStudent(studentName, studentLastName);
                            break;
                        }

                    case "удалить":
                        {
                            Console.Write("--- Введите идентификатор ученика ---\n" +
                                ">>> ");
                            int studentId = int.Parse(Console.ReadLine());

                            school.RemoveStudent(studentId);
                            break;
                        }

                    case "выход":
                        isRun = false;
                        break;
                }

                if (isRun)
                {
                    Console.WriteLine("--- Для продолжения нажмите любую клавишу ---");
                    Console.ReadKey();
                }
            }
        }
    }
}
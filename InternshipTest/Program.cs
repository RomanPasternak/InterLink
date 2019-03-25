using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;
using InternshipTest.Person;
using System;
using System.Collections.Generic;

namespace InternshipTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // read students
            List<Student> students = GetStudents();

            var university = new University("CH.U.I.");
            // add students to university
            university.AddStudents(students);

            // create intership for university
            var internship = new Internship("Interlink", university);

            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());
            Console.ReadKey();
        }

        private static List<Student> GetStudents()
        {
            var students = new List<Student>();

            var s = new Student("Alex");
            s.SetKnowledge(new Knowledge(85));
            students.Add(s);
            students.Add(new Student("Andrew Kostenko", new Knowledge(55)));
            students.Add(new Student("Julia Veselkina", new Knowledge(65)));
            students.Add(new Student("Maria Perechrest", new Knowledge(74)));
            students.Add(new Student("Ivan Dyvan"));

            return students;
        }
    }
}

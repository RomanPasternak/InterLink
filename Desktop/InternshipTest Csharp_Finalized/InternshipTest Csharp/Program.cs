using internshiptest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;
using InternshipTest.Person;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InternshipTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            // read students
            var provider = GetStudentsProvider();
            List<Student> students = provider.GetStudents();

            var university = new University("CH.U.I.");
            // add students to university
            university.AddStudents(students);
            Console.WriteLine("List of all students:");
            Console.WriteLine(string.Join(", ", students.Select(x => x.Name)));

            // create intership with minimal level of knowlenge for student
            var internship = new Internship("Interlink", university.GetAverageStudentsLevel());
            internship.ApplyToInternship(students);

            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());
            Console.ReadKey();
        }

        private static IStudentsProvider GetStudentsProvider()
        {
            return new HardCodedStudentsProvider();
        }
    }
}

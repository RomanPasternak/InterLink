using InternshipTest;
using InternshipTest.Person;
using System.Collections.Generic;

namespace internshiptest.Person
{
    public class HardCodedStudentsProvider : IStudentsProvider
    {
        public List<Student> GetStudents()
        {
            var students = new List<Student>();

            var s = new Student("Alex");
            s.SetKnowledge(new Knowledge(85));
            students.Add(s);
            students.Add(new Student("Andrew Kostenko", new Knowledge(60)));
            students.Add(new Student("Julia Veselkina", new Knowledge(65)));
            students.Add(new Student("Maria Perechrest", new Knowledge(74)));
            students.Add(new Student("Ivan Dyvan"));

            return students;
        }
    }

    public class FileSystemStudentsProvider : IStudentsProvider
    {
        public List<Student> GetStudents()
        {
            var students = new List<Student>();
            // TODO: get students from file
            return students;
        }
    }


    public class DataBaseStudentsProvider : IStudentsProvider
    {
        public List<Student> GetStudents()
        {
            var students = new List<Student>();
            // TODO: get students from database
            return students;
        }
    }
}

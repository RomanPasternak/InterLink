using InternshipTest.Person;
using System.Collections.Generic;
using System.Linq;

namespace InternshipTest.Institution
{
    public class University
    {
        private readonly List<Student> students = new List<Student>();

        public University(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public void AddStudents(List<Student> students)
        {
            this.students.AddRange(students);
        }

        public List<Student> GetStudents()
        {
            return this.students;
        }

        public int GetAverageStudentsLevel()
        {
            int level = 0;
            foreach (Student student in this.students)
            {
                level += student.GetStudentLevel();
            }
            level = level / this.students.Count;
            return level;
        }
    }
}

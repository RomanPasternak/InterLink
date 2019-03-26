using InternshipTest.Person;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        private readonly int minimalRequiredLevel;
        private readonly List<Student> students = new List<Student>();

        public Internship(string name, int minimalRequiredLevel)
        {
            this.Name = name;
            this.minimalRequiredLevel = minimalRequiredLevel;
        }

        public string Name { get; }

        public void ApplyToInternship(Student student)
        {
            if (IsSkilledEnough(student, this.minimalRequiredLevel))
            {
                this.students.Add(student);
            }
        }

        public void ApplyToInternship(List<Student> students)
        {
            IEnumerable<Student> skilledStudents = students.Where(student => this.IsSkilledEnough(student, this.minimalRequiredLevel));
            this.students.AddRange(skilledStudents);
        }

        public string GetStudents()
        {
            string result = this.GetStudentsNames(this.students);

            return result;
        }

        private string GetStudentsNames(IEnumerable<Student> students)
        {
            var builder = new StringBuilder();
            foreach (Student student in students)
            {
                builder.AppendLine(student.Name);
            }
            string result = builder.ToString();
            return result;
        }

        private bool IsSkilledEnough(Student student, int requiredLevel)
        {
            bool result = student.GetStudentLevel() > requiredLevel;
            return result;
        }
    }
}

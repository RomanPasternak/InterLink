using InternshipTest.Person;
using System.Text;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        public Internship(string name, University university)
        {
            this.Name = name;
            this.University = university;
        }

        public string Name { get; }
        public University University { get; }

        public string GetStudents()
        {
            var builder = new StringBuilder();
            int avgLevel = this.University.GetAverageStudentsLevel();
            foreach (Student student in this.University.GetStudents())
            {
                if (student.GetStudentLevel() > avgLevel)
                {
                    builder.AppendLine(student.Name);
                }
            }

            return builder.ToString();
        }
    }
}

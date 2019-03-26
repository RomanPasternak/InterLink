using System.Collections.Generic;
using InternshipTest.Person;

namespace internshiptest.Person
{
    public interface IStudentsProvider
    {
        List<Student> GetStudents();
    }
}
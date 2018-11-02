package institution.interlink;

import person.Student;

import java.util.ArrayList;
import java.util.List;

public class Internship {

    private List<Student> studentList = new ArrayList<>();
    private String internshipName;

    public Internship(String name) {
        this.internshipName = name;
    }

    public void setStudent(Student student) {
        studentList.add(student);
    }

    public List<Student> getStudents() {
        return studentList;
    }
}

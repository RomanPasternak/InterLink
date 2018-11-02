package institution;

import institution.interlink.Internship;
import person.Student;

import java.util.ArrayList;
import java.util.List;

public class University {

    private String name;
    private List<Student> studentList = new ArrayList<>();

    private Internship internship;

    public University(String name) {
        this.name = name;
    }

    public void addStudent(Student student) {
        this.studentList.add(student);
    }

    public void setInternship(Internship internship) {
        this.internship = internship;
    }

    public void setStudent(Student student) {
        if(student.getKnowledge().getLevel() > getAverageMark()) {
            internship.setStudent(student);
        }
    }

    private double getAverageMark() {
        double allMarks = 0;
        for(Student student : studentList) {
            allMarks += student.getKnowledge().getLevel();
        }

        return allMarks / studentList.size();
    }
}

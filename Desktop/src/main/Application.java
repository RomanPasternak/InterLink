package main;

import institution.University;
import institution.interlink.Internship;
import person.Student;
import person.consciousness.Knowledge;

public class Application {
    public static void main(String[] args) {
        University university = new University("CH.U.I.");
        Internship internship = new Internship("Interlink");

        Student low = new Student("low");
        low.setKnowledge(new Knowledge(1));

        Student low1 = new Student("low1");
        low1.setKnowledge(new Knowledge(1));

        Student middle = new Student("mid");
        middle.setKnowledge(new Knowledge(2));

        university.addStudent(low);
        university.addStudent(low1);
        university.addStudent(middle);

        university.setInternship(internship);
        university.setStudent(low);
        university.setStudent(low1);
        university.setStudent(middle);

        System.out.println(internship.getStudents());
    }
}

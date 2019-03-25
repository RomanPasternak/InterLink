namespace InternshipTest.Person
{
    public class Student
    {
        private Knowledge knowledge;

        public Student(string name)
            :this(name, new Knowledge(50))
        {
        }

        public Student(string name, Knowledge knowledge)
        {
            this.knowledge = knowledge;
            this.Name = name;
        }

        public string Name { get; }

        public void SetKnowledge(Knowledge knowledge)
        {
            this.knowledge = knowledge;
        }

        public int GetStudentLevel()
        {
            return knowledge.Level;
        }
    }
}
namespace Classes.Lib
{
    public class Student : Person
    {
        public string faculty;
        public Progress progress;
        public bool isStudy;

        public Student(string faculty)
        {
            this.faculty = faculty;
            progress = new Progress();
            isStudy = true;
        }
    }
}

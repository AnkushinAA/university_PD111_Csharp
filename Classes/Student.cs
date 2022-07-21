namespace Classes.Lib
{
    public class Student : Person
    {
        public string faculty;
        public Progress progress;
        public bool isStudy;

        public Student()
        {
            faculty = ConsoleEdit("факультет:");
            progress = new Progress();
            isStudy = true;
        }
    }
}

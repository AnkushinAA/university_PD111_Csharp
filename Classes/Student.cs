namespace Classes.Lib
{
    public class Student : Person
    {
        public string faculty;        
        public bool isStudy;

        public Student()
        {
            faculty = ConsoleEdit("факультет:");           
            isStudy = true;
        }
    }
}

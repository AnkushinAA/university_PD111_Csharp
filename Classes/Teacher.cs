namespace Classes.Lib
{
    public class Teacher : Staff
    {
        public string subject;

        public Teacher()
        {
            subject = ConsoleEdit("предмет:");
        }
    }
}

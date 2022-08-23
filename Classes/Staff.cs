namespace Classes.Lib
{
    public class Staff : Person
    {
        public string department;
        public string position;
        public bool isWork;

        public Staff()
        {
            department = ConsoleEdit("отдел:");
            position = ConsoleEdit("должность:");
            isWork = true;
        }

    }
}

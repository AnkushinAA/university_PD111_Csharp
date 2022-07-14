namespace Classes.Lib
{
    public class Staff : Person
    {
        public string department;
        public string position;
        public bool isWork;

        public Staff(string department, string position, bool isWork)
        {
            this.department = department;
            this.position = position;
            this.isWork = isWork;
        }
        public Staff() { }
    }
}

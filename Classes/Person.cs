namespace Classes.Lib
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public Date birthday;
        public Contact contact;

        public Person()
        {
            firstName = ConsoleEdit("Ведите Имя:");
            lastName = ConsoleEdit("Фамилию:");
            birthday = new Date();
            contact = new Contact();
        }
        protected string ConsoleEdit(string str)
        {
            Console.WriteLine(str);
            string s = Console.ReadLine();
            return s;
        }
    }
}
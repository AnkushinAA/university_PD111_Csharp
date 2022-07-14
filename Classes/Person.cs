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
            birthday = new Date();
            contact = new Contact();
        }
    }
}
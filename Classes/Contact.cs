namespace Classes.Lib
{
    public class Contact
    {
        public string adress;
        public string phone;

        public Contact()
        {
            adress = ConsoleEdit("адрес:");
            phone = ConsoleEdit("Телефон:");
        }
        protected string ConsoleEdit(string str)
        {
            Console.WriteLine(str);
            string s = Console.ReadLine();
            return s;
        }
    }
}

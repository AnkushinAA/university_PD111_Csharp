namespace Classes.Lib
{
    public class Date
    {
        public int day;
        public int month;
        public int year;
        public string data;

        public Date()
        {
            data = ConsoleEdit("Введите дату в формате дд.мм.гггг");
            string[] str = data.Split('.');
            day = Convert.ToInt32(str[0]);
            month = Convert.ToInt32(str[1]);
            year = Convert.ToInt32(str[2]);
            data = $"{day}|{month}|{year}";
        }
        protected string ConsoleEdit(string str)
        {
            Console.WriteLine(str);
            string s = Console.ReadLine();
            return s;
        }
    }
}

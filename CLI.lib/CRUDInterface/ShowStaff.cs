using CLI.lib;
using CRUD.lib;

namespace Interface.lib.CRUDInterface
{
    internal class ShowStaff : IShow
    {
        public (int idPerson, int id) FindIdElement(string firstName)
        {
            var temp = from str in Temp.person
                       join str1 in Temp.staff on str equals str1
                       where str.Split("|")[0] == str1.Split("|")[1] && str.Split("|")[1] == firstName
                       select (Convert.ToInt32(str.Split("|")[0], Convert.ToInt32(str1.Split("|")[0]))); //???
            int id = temp.First();      //???
            int idPerson = temp.Last(); //???
            return (idPerson, id);
        }

        public void ShowAllElement()
        {
            var temp = from str in Temp.person
                       join str1 in Temp.staff on str equals str1
                       where str.Split("|")[0] == str1.Split("|")[1]
                       select (str, str1);
            PrintConsole(temp);
        }
        private void PrintConsole(IEnumerable<(string str, string str1)> temp )
        {            
            foreach(var s in temp)
            {
                string[] person = s.str.Split('|');
                string[] staff = s.str1.Split('|');
                foreach(var f in person)
                {
                    Console.Write($"{f} ");
                }
                Console.WriteLine();
                foreach (var f in staff)
                {
                    Console.Write($"{f} ");
                }
                Console.WriteLine();
            }
        }

        public void ShowElement(string firstName)
        {
            var temp = from str in Temp.person
                       join str1 in Temp.staff on str equals str1
                       where str.Split("|")[0] == str1.Split("|")[1] && str.Split("|")[1] == firstName
                       select (str, str1);
            PrintConsole(temp);
        }
    }
}

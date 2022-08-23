using Classes.Lib;
using Interface.lib;

namespace CRUDInterface
{
    internal class ShowStudent : IShow
    {
        public (int idPerson, int id) FindIdElement(string firstName)
        {
            var temp = from str in Temp.person
                       join str1 in Temp.staff on str equals str1
                       where str.Split("|")[0] == str1.Split("|")[1] && str.Split("|")[1] == firstName
                       select (Convert.ToInt32(str.Split("|")[0], Convert.ToInt32(str1.Split("|")[0])));//???
            int id = temp.First();      //???
            int idPerson = temp.Last(); //???
            return (idPerson, id);
        }

        public void ShowAllElement()
        {
            var temp = from person in Temp.person
                       join staff in Temp.staff on person equals staff
                       where person.Split("|")[0] == staff.Split("|")[1]
                       select (person, staff);
            PrintConsole(temp);
            PrintProgress(temp);
        }

        private void PrintProgress(IEnumerable<(string person, string staff)> temp)
        {                    
            foreach (var str in temp)
            {                
                foreach(var d in ProgressTemp.progress)
                {
                    Console.WriteLine(d.Key);
                    var data = from mark in d.Value
                               where mark.Substring(0, mark.IndexOf("|"))==str.staff.Substring(0, str.staff.IndexOf("|"))
                               select mark;
                    PrintConsole(data);
                }
            }
        }

        private void PrintConsole(IEnumerable<(string str, string str1)> temp)
        {
            foreach (var s in temp)
            {
                string[] person = s.str.Split('|');
                string[] staff = s.str1.Split('|');
                foreach (var f in person)
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
        private void PrintConsole(IEnumerable<string> str)
        {
            foreach(var s in str)
            {
                string[] ar = s.Split('|');
                foreach(var f in ar)
                {
                    Console.Write($"{f} ");
                }
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

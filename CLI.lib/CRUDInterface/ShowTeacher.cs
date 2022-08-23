using Classes.Lib;
using Interface.lib;

namespace CRUDInterface
{
    internal class ShowTeacher : IShow
    {
        public (int idPerson, int id) FindIdElement(string firstName)
        {
            var temp = from person in Temp.person
                       join teacher in Temp.teacher on person equals teacher
                       where person.Split("|")[0] == teacher.Split("|")[1] && person.Split("|")[1] == firstName
                       select (Convert.ToInt32(person.Split("|")[0], Convert.ToInt32(teacher.Split("|")[0]))); //???           
            int id = temp.First();      //???
            int idPerson = temp.Last(); //???
            return (idPerson, id);
        }

        public void ShowAllElement()
        {
            var temp = from person in Temp.person
                       join staff in Temp.staff on person equals staff
                       join teacher in Temp.teacher on person equals teacher
                       where person.Split("|")[0] == staff.Split("|")[1] && person.Split("|")[0] == teacher.Split("|")[1]
                       select (person, staff, teacher);
            PrintConsole(temp);
        }
        private void PrintConsole(IEnumerable<(string str, string str1, string str2)> temp)
        {
            foreach (var s in temp)
            {
                string[] person = s.str.Split('|');
                string[] staff = s.str1.Split('|');
                string[] teacher = s.str2.Split('|');
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
                foreach (var f in teacher)
                {
                    Console.Write($"{f} ");
                }
                Console.WriteLine();
            }
        }

        public void ShowElement(string firstName)
        {
            var temp = from person in Temp.person
                       join staff in Temp.staff on person equals staff
                       join teacher in Temp.teacher on person equals teacher
                       where person.Split("|")[0] == staff.Split("|")[1] && person.Split("|")[1] == firstName && person.Split("|")[1] == teacher.Split("|")[1]
                       select (person, staff, teacher);
            PrintConsole(temp);
        }
    }
}

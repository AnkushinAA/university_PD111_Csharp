using Classes.Lib;
using CLI.lib;
using CRUD.lib;

namespace Interface.lib.CRUDInterface
{
    internal class ChangeStudent : IChange, IProgress
    {
        public void Change(string lastName, string oldData, string newData)
        {
            IShow show = new ShowStaff();
            var id = show.FindIdElement(lastName);
            List<string> tempList = new List<string>();
            foreach (string str in Temp.person)
            {
                if (str.IndexOf(oldData) >= 0 && str.IndexOf(Convert.ToString(id.idPerson)) >= 0)
                {
                    tempList.Add(str.Replace(oldData, newData));
                }
                else
                {
                    tempList.Add(str);
                }
            }
            Temp.person = tempList;
            foreach (string str in Temp.student)
            {
                if (str.IndexOf(oldData) >= 0 && str.IndexOf(Convert.ToString(id.id)) >= 0)
                {
                    tempList.Add(str.Replace(oldData, newData));
                }
                else
                {
                    tempList.Add(str);
                }
            }
            Temp.student = tempList;
            // TODO запись данных в файлы
        }
        public void AddProgress(string lastName, string subject)
        {
            IShow show = new ShowStaff();
            var id = show.FindIdElement(lastName);           
            Console.WriteLine("Введите оценку");
            int mark = Console.Read();
            if (subject == "математика")
            {
                AddMark(ProgressTemp.matematic, id.id, mark);
            }
            if (subject == "история")
            {
                AddMark(ProgressTemp.history, id.id, mark);
            }
            WriteFile();
        }
        private void AddMark(List<string> list, int id, int mark)
        {
            List<string> tempList = new List<string>();
            foreach (string str in ProgressTemp.history)
            {
                if (Convert.ToInt32(str.Substring(0, str.IndexOf("|"))) == id)
                {
                    str.Insert(str.Length, mark.ToString());
                    tempList.Add(str);
                }
                else
                {
                    tempList.Add(str);
                }
            }
            ProgressTemp.history = tempList;
        }
        private void WriteFile()
        {
            // TODO запись данных в файлы
        }
    }
}

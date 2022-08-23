using Classes.Lib;
using Interface.lib;

namespace CRUDInterface
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
        public void AddProgress(string lastName, int itemSubject)
        {
            IShow show = new ShowStaff();
            var id = show.FindIdElement(lastName);
            Console.WriteLine("Введите оценку");
            int mark = Console.Read();
            AddMark(itemSubject, id.id, mark);
            WriteFile();
        }
        private void AddMark(int itemSubject, int id, int mark)
        {
            List<string> tempList = new List<string>();
            foreach (string str in ProgressTemp.progress[Subject.subject[itemSubject]])
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
            ProgressTemp.progress[Subject.subject[itemSubject]] = tempList;
        }
        private void WriteFile()
        {
            // TODO запись данных в файлы
        }
    }
}

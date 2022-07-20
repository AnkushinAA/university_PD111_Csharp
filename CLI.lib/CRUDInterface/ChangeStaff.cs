using CLI.lib;
using CRUD.lib;

namespace Interface.lib.CRUDInterface
{
    internal class ChangeStaff : IChange
    {
        public void Change(string firstName, string oldData, string newData)
        {
            IShow show = new ShowStaff();
            var id = show.FindIdElement(firstName);
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
            foreach (string str in Temp.staff)
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
            Temp.staff = tempList;
            // TODO запись данных в файлы
        }
    }
}

using CLI.lib;
using CRUD.lib;

namespace Interface.lib.CRUDInterface
{
    internal class ChangeTeacher : IChange
    {
        public void Change(string firstName, string oldData, string newData)
        {
            IShow show = new ShowTeacher();
            var id = show.FindIdElement(firstName);
            List<string> tempList = new List<string>();
            int status = 0;
            foreach (string str in Temp.teacher)
            {
                if (str.IndexOf(oldData) >= 0 && str.IndexOf(Convert.ToString(id.id)) >= 0)
                {
                    tempList.Add(str.Replace(oldData, newData));
                    status++;
                }
                else
                {
                    tempList.Add(str);
                }
            }
            Temp.teacher = tempList;
            if(status == 0)
            {
                IChange change = new ChangeStaff();
                change.Change(firstName,oldData,newData);
            }
            WriteFile();
        }
        private void WriteFile()
        {
            // TODO запись данных в файлы
        }
    }
}

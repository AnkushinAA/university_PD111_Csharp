using CLI.lib;
using CRUD.lib;

namespace Interface.lib.CRUDInterface
{
    internal class DismissStaff : IDismiss
    {        
        public void Dismiss(string lastName)
        {
            var dismiss = new ShowStaff();
            int idStaff = (dismiss.FindIdElement(lastName)).id;
            List<string> list = new List<string>();
            foreach(string str in Temp.staff)
            {
                if((Convert.ToInt32(str.Substring(0,(str.IndexOf("|"))))) == idStaff)
                {
                    list.Add(str.Replace("True", "False"));
                }
                else
                {
                    list.Add(str);
                }
            }
            Temp.staff = list;
            // TODO запись данных в файлы
        }
    }
}

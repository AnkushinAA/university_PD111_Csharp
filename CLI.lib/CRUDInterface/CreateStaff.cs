
using Classes.Lib;
using CLI.lib;

namespace CRUD.lib.CRUDInterface
{
    public class CreateStaff : ICreate
    {
        public void Create()
        {
            var staff = new Staff();
            int idPerson = Maxid(Temp.person);
            int idStaff = Maxid(Temp.staff);
            string strPerson = ($"{idPerson}|{staff.lastName}|{staff.firstName}|{staff.contact.phone}|{staff.contact.adress}");
            string strStaff = ($"{idStaff}|{idPerson}|{staff.department}|{staff.position}|{staff.isWork}");
            Temp.person.Add(strPerson);
            Temp.staff.Add(strStaff);
            // TODO запись данных в файлы
        }       
        private int Maxid(List<string> list)
        {
            IEnumerable<int> temp = null;
            foreach (var str in list)
            {
                temp.Append(Convert.ToInt32(str.Substring(0, str.IndexOf("|"))));
            }
             var id = temp.Max() + 1;
            return id;
        }
    }
}

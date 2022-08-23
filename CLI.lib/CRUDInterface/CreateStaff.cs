using Classes.Lib;
using Interface.lib;

namespace CRUDInterface
{
    public class CreateStaff : ICreate
    {
        public void Create()
        {
            Staff staff = new();
            int idPerson = Maxid(Temp.person);
            int idStaff = Maxid(Temp.staff);
            string strPerson = $"{idPerson}|{staff.lastName}|{staff.firstName}|{staff.contact.phone}|{staff.contact.adress}";
            string strStaff = $"{idStaff}|{idPerson}|{staff.department}|{staff.position}|{staff.isWork}";
            Temp.person.Add(strPerson);
            Temp.staff.Add(strStaff);
            // TODO запись данных в файлы
        }
        private int Maxid(List<string> list)
        {
            IEnumerable<int> temp = null;
            foreach (string str in list)
            {
                _ = temp.Append(Convert.ToInt32(str[..str.IndexOf("|")]));
            }
            int id = temp.Max() + 1;
            return id;
        }
    }
}

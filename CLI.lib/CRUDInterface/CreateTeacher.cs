using Classes.Lib;
using CLI.lib;

namespace CRUD.lib.CRUDInterface
{
    public class CreateTeacher : ICreate
    {
        public void Create()
        {
            var teacher = new Teacher();
            int idPerson = Maxid(Temp.person);
            int idStaff = Maxid(Temp.staff);
            int idTeacher = Maxid(Temp.teacher);
            string strPerson = ($"{idPerson}|{teacher.lastName}|{teacher.firstName}|{teacher.contact.phone}|{teacher.contact.adress}");
            string strStaff = ($"{idStaff}|{idPerson}|{teacher.department}|{teacher.position}|{teacher.isWork}");
            string strTeacher = ($"{idTeacher}|{idPerson}|{teacher.subject}");
            Temp.person.Add(strPerson);
            Temp.staff.Add(strStaff);
            Temp.teacher.Add(strTeacher);
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

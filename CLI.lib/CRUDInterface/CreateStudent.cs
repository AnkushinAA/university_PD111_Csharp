using Classes.Lib;
using CLI.lib;

namespace CRUD.lib.CRUDInterface
{
    public class CreateStudent : ICreate
    {
        public void Create()
        {
            var student = new Student();
            int idPerson = Maxid(Temp.person);
            int idStudent = Maxid(Temp.student);
            string strPerson = ($"{idPerson}|{student.lastName}|{student.firstName}|{student.contact.phone}|{student.contact.adress}");
            string strStaff = ($"{idStudent}|{idPerson}|{student.faculty}|{student.isStudy}");
            Temp.person.Add(strPerson);
            Temp.staff.Add(strStaff);
            CreateProgress(idStudent);
            // TODO запись данных в файлы
        }
        private void CreateProgress(int id)
        {
            foreach (var student in ProgressTemp.Temp)
            {
                student.Value.Add($"{Convert.ToString(id)}|");
            }
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

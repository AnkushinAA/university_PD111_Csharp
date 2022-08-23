using Classes.Lib;
using Interface.lib;

namespace CRUDInterface
{
    public class CreateStudent : ICreate
    {
        public void Create()
        {
            Student student = new();
            int idPerson = Maxid(Temp.person);
            int idStudent = Maxid(Temp.student);
            string strPerson = $"{idPerson}|{student.lastName}|{student.firstName}|{student.contact.phone}|{student.contact.adress}";
            string strStaff = $"{idStudent}|{idPerson}|{student.faculty}|{student.isStudy}";
            Temp.person.Add(strPerson);
            Temp.staff.Add(strStaff);
            CreateProgress(idStudent);
            // TODO запись данных в файлы
        }
        private void CreateProgress(int id)
        {
            foreach (KeyValuePair<string, List<string>> student in ProgressTemp.progress)
            {
                student.Value.Add($"{Convert.ToString(id)}|");
            }
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

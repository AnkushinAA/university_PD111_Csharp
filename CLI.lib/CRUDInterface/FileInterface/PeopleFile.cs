using CLI.lib;
using CRUD.lib;

namespace Interface.lib.CRUDInterface.FileInterface
{
    internal class PeopleFile : IFile
    {
        public void ReadFile()
        {
            FileNames names = new FileNames();
            Read(Temp.person, names.fileNamePeople[0]);
            Read(Temp.student, names.fileNamePeople[1]);
            Read(Temp.staff, names.fileNamePeople[2]);
            Read(Temp.teacher, names.fileNamePeople[3]);
        }
        private void Read(List<string> list, string name)
        {
            var file = new StreamReader(name);
            string temp = file.ReadToEnd();
            file.Close();
            string[] mass = temp.Split("\r\n");
            foreach (var str in mass)
            {
                list.Add(str);
            }
        }

        public void WriteFile()
        {
            FileNames names = new FileNames();
            Write(Temp.person, names.fileNamePeople[0]);
            Write(Temp.student, names.fileNamePeople[1]);
            Write(Temp.staff, names.fileNamePeople[2]);
            Write(Temp.teacher, names.fileNamePeople[3]);
        }
        private void Write(List<string> list,string name)
        {
            var file = new StreamWriter(name);
            foreach(var str in list)
            {
                file.WriteLine(str);
            }
            file.Close();
        }
    }
}

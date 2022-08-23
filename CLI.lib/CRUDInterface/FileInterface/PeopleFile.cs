using Classes.Lib;
using Interface;

namespace FileInterface
{
    internal class PeopleFile : IFile
    {
        public void ReadFile()
        {
            FileNames names = new();
            Read(Temp.person, names.fileNamePeople[0]);
            Read(Temp.student, names.fileNamePeople[1]);
            Read(Temp.staff, names.fileNamePeople[2]);
            Read(Temp.teacher, names.fileNamePeople[3]);
        }
        private void Read(List<string> list, string name)
        {
            StreamReader file = new(name);
            string temp = file.ReadToEnd();
            file.Close();
            string[] mass = temp.Split("\r\n");
            foreach (string str in mass)
            {
                list.Add(str);
            }
        }

        public void WriteFile()
        {
            FileNames names = new();
            Write(Temp.person, names.fileNamePeople[0]);
            Write(Temp.student, names.fileNamePeople[1]);
            Write(Temp.staff, names.fileNamePeople[2]);
            Write(Temp.teacher, names.fileNamePeople[3]);
        }
        private void Write(List<string> list, string name)
        {
            StreamWriter file = new(name);
            foreach (string str in list)
            {
                file.WriteLine(str);
            }
            file.Close();
        }
    }
}

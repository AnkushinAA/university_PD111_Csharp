using Classes.Lib;
using Interface;

namespace FileInterface
{
    internal class ProgressFile : IFile
    {
        public void ReadFile()
        {
            FileNames names = new FileNames();
            var d = new Dictionary<string, List<string>>();
            for (int i = 0; i < Subject.subject.Length; i++)
            {
                d.Add(Subject.subject[i], new List<string>());
                StreamReader file = new StreamReader(new FileStream (names.fileNameProgress[i], FileMode.OpenOrCreate));
                string str = file.ReadToEnd();
                string[] mass = str.Split("|");
                foreach (string s in mass)
                {
                    d[Subject.subject[i]].Add(s);
                }
            }
            ProgressTemp.progress = d;
        }

        public void WriteFile()
        {
            FileNames names = new FileNames();
            for (int i =0; i< Subject.subject.Length; i++)
            {
                var file = new StreamWriter(names.fileNameProgress[i], append:false);
                foreach (string str in ProgressTemp.progress[Subject.subject[i]])
                {
                    file.Write(str);
                }
            }
        }
    }
}

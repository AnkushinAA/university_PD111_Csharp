namespace Classes.Lib
{
    public class FileNames : Subject
    {
        public readonly string[] fileNamePeople = { @"Files\Person.csv", @"Files\Student.csv", @"Files\Staff.csv", @"Files\Teacher.csv" };
        public readonly string[] fileNameProgress;

        public FileNames()
        {
            fileNameProgress = new string[subject.Length];
            for (int i = 0; i < subject.Length; i++)
            {
                fileNameProgress[i] = $@"Files\{subject[i]}.csv";
            }

        }
    }
}

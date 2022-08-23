namespace Classes.Lib
{
    public class FileNames : Subject
    {
        public readonly string[] fileNamePeople = { "Person.csv", "Student.csv", "Staff.csv", "Teacher.csv" };
        public readonly string[] fileNameProgress;

        public FileNames()
        {
            fileNameProgress = new string[subject.Length];
            for (int i = 0; i < subject.Length; i++)
            {
                fileNameProgress[i] = $"{subject[i]}.csv";
            }

        }
    }
}

namespace Classes.Lib
{
    public class ProgressTemp : Subject
    {
        public static Dictionary<string, List<string>> progress = new();

        private ProgressTemp()
        {
            foreach (string str in subject)
            {
                progress.Add(str, new List<string>());
            }
        }
    }
}

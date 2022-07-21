
namespace Classes.Lib
{
    public class Progress
    {
        public Dictionary<string, List<int>> progress;
        public Progress()
        {
            progress = new Dictionary<string, List<int>>();
            string[] str = { "Математика", "История" };
            foreach (string str2 in str)
            {
                progress.Add(str2, new List<int>());
            }
        }
    }
}

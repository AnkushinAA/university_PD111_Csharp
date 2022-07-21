
namespace Classes.Lib
{
    public class Progress
    {
        public Dictionary<string, List<int>> progress;
        public Progress()
        {
            progress = new Dictionary<string, List<int>>();            
            foreach (string str2 in Subject.subject)
            {
                progress.Add(str2, new List<int>());
            }
        }
    }
}

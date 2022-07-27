using Classes.Lib;

namespace CRUD.lib
{
    public class ProgressTemp: Subject
    {
       public static Dictionary<string, List<string>> progress = new Dictionary<string, List<string>>();
        ProgressTemp ()
        {
            foreach (string str in subject)
            {                
                progress.Add(str, new List<string>());
            }
        }
    }
}

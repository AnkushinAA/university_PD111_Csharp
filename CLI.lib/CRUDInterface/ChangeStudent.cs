using CLI.lib;

namespace Interface.lib.CRUDInterface
{
    internal class ChangeStudent : IChange, IProgress
    {
        public void Change(string firstName, string oldData, string newData)
        {
            throw new NotImplementedException();
            // TODO запись данных в файлы
        }
        public void AddProgress(string firstname, string subject)
        {
            // TODO запись данных в файлы
        }
    }
}

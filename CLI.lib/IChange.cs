namespace CLI.lib
{
    internal interface IChange
    {
        public void Find(string str);
        public void Change(string str);
        public void Write(string str);
        public void ChangeProgress(string str, int mark);
    }
}

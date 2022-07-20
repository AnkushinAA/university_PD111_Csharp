namespace CLI.lib
{
    internal interface IShow
    {
        public void ShowElement(string firstName);
        public void ShowAllElement();
        public (int idPerson, int id) FindIdElement(string firstName);
        
    }
}

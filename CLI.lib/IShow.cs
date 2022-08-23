namespace Interface.lib
{
    internal interface IShow
    {
        public void ShowElement(string lastName);
        public void ShowAllElement();
        public (int idPerson, int id) FindIdElement(string lastName);

    }
}

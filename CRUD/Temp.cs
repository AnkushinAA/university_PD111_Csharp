namespace CRUD.lib
{
    public class Temp
    {
        public List<string> person { get; set; }
        public List<string> student { get; set; }
        public List<string> teacher { get; set; }
        public List<string> staff { get; set; }
        public List<string> matematicProgress { get; set; }
        public  static Temp self;
        public static Temp Singleton()
        {
            if (self == null)
            {
                self = new Temp();
            }
            return self;
        }
        private Temp()
        {
            Singleton();
        }

    }
}
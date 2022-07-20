namespace CLI.lib
{
    public class TeacherMenu: ConsoleMenu
    {
        public TeacherMenu(string[] Items) : base(Items)
        {
        }

        public delegate void method();
        public static void MenuTeacher()
        {
            string[] items = { "Новый учитель", "Изменить данные учителя", "уволить учителя", "вернуться в предыдущее меню" };
            method[] methods = new method[] { CreateTeacher, ChangeTeacher, ExpelTeacher, ShowTeacher, AboveMenu };
            ConsoleMenu menuTeacher = new(items);
            int menuResult;
            do
            {
                menuResult = menuTeacher.PrintMenu();
                if (menuResult == 4)
                {
                    methods[4]();
                    return;
                }
                methods[menuResult]();
                Console.WriteLine("Для продолжения нажмите любую клавишу");
                _ = Console.ReadKey();
            } while (menuResult != items.Length - 1);
        }

        private static void CreateTeacher()
        {
            Console.WriteLine("Вносим данные о новом учителе");
        }

        private static void ChangeTeacher()
        {
            Console.WriteLine("Вносим изменения в данные о учителе");
        }

        private static void ExpelTeacher()
        {
            Console.WriteLine("увольняем учителя");
        }

        private static void ShowTeacher()
        {
            Console.WriteLine("Выводим данные учителя");
        }
        private static void AboveMenu()
        {
            Console.WriteLine("переходим выше в меню");
            Menu.Program();
        }
    }
}

namespace CLI.lib
{
    public class StudentMenu: ConsoleMenu
    {
        public StudentMenu(string[] Items) : base(Items)
        {
        }
        public delegate void method();
        public static void MenuStudent()
        {
            string[] items = { "Новый студент", "Изменить данные студента", "Отчислить студента", "вернуться в предыдущее меню" };
            method[] methods = new method[] { CreateStudent, ChangeStudent, ExpelStudent,ShowStudent, AboveMenu };
            ConsoleMenu menuStudent = new(items);
            int menuResult;
            do
            {
                menuResult = menuStudent.PrintMenu();
                methods[menuResult]();
                Console.WriteLine("Для продолжения нажмите любую клавишу");
                _ = Console.ReadKey();
            } while (menuResult != items.Length - 1);
        }

        private static void CreateStudent()
        {
            Console.WriteLine("Вносим данные о новом студенте");
        }

        private static void ChangeStudent()
        {
            Console.WriteLine("Вносим изменения в данные о студенте");
        }

        private static void ExpelStudent()
        {
            Console.WriteLine("Отчисляем студента");
        }
        private static void ShowStudent()
        {
            Console.WriteLine("Выводим данные студента");
        }

        private static void AboveMenu()
        {
            Console.WriteLine("переходим выше в меню");
            Menu.Program();
        }
    }
}

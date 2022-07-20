using CRUD.lib.CRUDInterface;

namespace CLI.lib
{
    public class StaffMenu: ConsoleMenu
    {
        public StaffMenu(string[] Items) : base(Items)
        {
        }
        public delegate void method();
        public static void MenuStaff()
        {
            string[] items = { "Новый сотрудник", "Изменить данные сотрудника", "уволить сотрудника", "вернуться в предыдущее меню" };
            method[] methods = new method[] { CreateStaff, ChangeStaff, ExpelStaff, ShowStaff, AboveMenu };
            ConsoleMenu menuStaff = new(items);
            int menuResult;
            do
            {
                menuResult = menuStaff.PrintMenu();
                methods[menuResult]();
                Console.WriteLine("Для продолжения нажмите любую клавишу");
                _ = Console.ReadKey();
            } while (menuResult != items.Length - 1);
        }

        private static void CreateStaff()
        {
            Console.WriteLine("Вносим данные о новом сотруднике");
            ICreate create = new CreateStaff();
        }

        private static void ChangeStaff()
        {
            Console.WriteLine("Вносим изменения в данные о сотруднике");
        }

        private static void ExpelStaff()
        {
            Console.WriteLine("увольняем сотрудника");
        }
        private static void ShowStaff()
        {
            Console.WriteLine("Выводим данные Сотрудника");
        }

        private static void AboveMenu()
        {
            Console.WriteLine("переходим выше в меню");
            Menu.Program();
        }
    }
}

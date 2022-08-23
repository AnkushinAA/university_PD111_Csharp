using CRUDInterface;

namespace Interface.lib
{
    public class StaffMenu : ConsoleMenu
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

        private static void CreateStaff()
        {
            Console.WriteLine("Вносим данные о новом сотруднике");
            ICreate create = new CreateStaff();
            create.Create();
        }

        private static void ChangeStaff()
        {
            Console.WriteLine("Вносим изменения в данные о сотруднике");
            IChange change = new ChangeStaff();
            Console.WriteLine("Ведите Фамилию:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Ведите значение которое нужно изменить:");
            string oldData = Console.ReadLine();
            Console.WriteLine("Ведите значение которое нужно внести:");
            string newData = Console.ReadLine();
            change.Change(lastName, oldData, newData);
        }

        private static void ExpelStaff()
        {
            Console.WriteLine("увольняем сотрудника");
            IDismiss dismiss = new DismissStaff();
            Console.WriteLine("Ведите Фамилию:");
            string str = Console.ReadLine();
            dismiss.Dismiss(str);
        }
        private static void ShowStaff()
        {
            IShow show = new ShowStaff();
            Console.WriteLine("1- Выводим данные сотрудника");
            Console.WriteLine("2- Выводим данные всех сотрудников");
            int n = Console.Read();
            if (n == 1)
            {
                Console.WriteLine("Ведите Фамилию:");
                string str = Console.ReadLine();
                show.ShowElement(str);
            }
            if (n == 2)
            {
                show.ShowAllElement();
            }
        }

        private static void AboveMenu()
        {
            Console.WriteLine("переходим выше в меню");
        }
    }
}

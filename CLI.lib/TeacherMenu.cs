using CRUD.lib.CRUDInterface;
using Interface.lib.CRUDInterface;

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
            ICreate create = new CreateTeacher();
            create.Create();
        }

        private static void ChangeTeacher()
        {
            Console.WriteLine("Вносим изменения в данные о учителе");           
            IChange change = new ChangeTeacher();
            Console.WriteLine("Ведите Фамилию:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Ведите значение которое нужно изменить:");
            string oldData = Console.ReadLine();
            Console.WriteLine("Ведите значение которое нужно внести:");
            string newData = Console.ReadLine();
            change.Change(lastName, oldData, newData);
        }

        private static void ExpelTeacher()
        {
            Console.WriteLine("увольняем учителя");
            IDismiss dismiss = new DismissStaff();
            Console.WriteLine("Ведите Фамилию:");
            string str = Console.ReadLine();
            dismiss.Dismiss(str);
        }

        private static void ShowTeacher()
        {
            IShow show = new ShowTeacher();
            Console.WriteLine("1- Выводим данные учителя");
            Console.WriteLine("2- Выводим данные всех учителей");
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

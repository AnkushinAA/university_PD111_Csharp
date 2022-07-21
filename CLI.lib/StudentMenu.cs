using CRUD.lib.CRUDInterface;
using Interface.lib;
using Interface.lib.CRUDInterface;

namespace CLI.lib
{
    public class StudentMenu : ConsoleMenu
    {
        public StudentMenu(string[] Items) : base(Items)
        {
        }
        public delegate void method();
        public static void MenuStudent()
        {
            string[] items = { "Новый студент", "Изменить данные студента", "Отчислить студента", "вернуться в предыдущее меню" };
            method[] methods = new method[] { CreateStudent, ChangeStudent, ExpelStudent, ShowStudent, AboveMenu };
            ConsoleMenu menuStudent = new(items);
            int menuResult;
            do
            {
                menuResult = menuStudent.PrintMenu();
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

        private static void CreateStudent()
        {
            Console.WriteLine("Вносим данные о новом студенте");
            ICreate create = new CreateStudent();
            create.Create();
        }

        private static void ChangeStudent()
        {
            Console.WriteLine("1- Вносим изменения в данные о студенте");
            Console.WriteLine("2- Вносим изменения в оценочную ведомость");
            int n = Console.Read();
            IChange change = new ChangeStudent(); // ChangeStudent change = new ChangeStudent(); ???
            Console.WriteLine("Ведите Фамилию:");
            string lastName = Console.ReadLine();
            if (n == 1)
            {
                Console.WriteLine("Ведите значение которое нужно изменить:");
                string oldData = Console.ReadLine();
                Console.WriteLine("Ведите значение которое нужно внести:");
                string newData = Console.ReadLine();
                change.Change(lastName, oldData, newData);
            }
            if(n == 2)
            {
                IProgress progress = new ChangeStudent(); // ???
                Console.WriteLine("Ведите пердмет:");
                string subject = Console.ReadLine();
                progress.AddProgress(lastName, subject);
            }                     
        }

        private static void ExpelStudent()
        {
            Console.WriteLine("Отчисляем студента");
            IDismiss dismiss = new DismissStudent();
            Console.WriteLine("Ведите Фамилию:");
            string str = Console.ReadLine();
            dismiss.Dismiss(str);
        }
        private static void ShowStudent()
        {            
            IShow show = new ShowStudent();
            Console.WriteLine("1- Выводим данные студента");
            Console.WriteLine("2- Выводим данные всех студентов");
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

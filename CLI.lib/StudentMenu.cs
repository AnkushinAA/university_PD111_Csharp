using Classes.Lib;
using CRUDInterface;

namespace Interface.lib
{
    public class StudentMenu : ConsoleMenu
    {
        public StudentMenu(string[] Items) : base(Items)
        {
        }
        public delegate void method();
        public static void MenuStudent()
        {
            string[] items = { "Новый студент", "Изменить данные студента", "Отчислить студента", "Показать данные студента", "вернуться в предыдущее меню" };
            method[] methods = new method[] { CreateStudent, ChangeStudent, ExpelStudent, ShowStudent};
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
            string[] items = { "Вносим изменения в данные о студенте", "Вносим изменения в оценочную ведомость" };
            ConsoleMenu menuStudent = new(items);
            int n = menuStudent.PrintMenu();
            IChange change = new ChangeStudent(); // ChangeStudent change = new ChangeStudent(); ???
            Console.WriteLine("Ведите Фамилию:");
            string lastName = Console.ReadLine();
            if (n == 0)
            {
                Console.WriteLine("Ведите значение которое нужно изменить:");
                string oldData = Console.ReadLine();
                Console.WriteLine("Ведите значение которое нужно внести:");
                string newData = Console.ReadLine();
                change.Change(lastName, oldData, newData);
            }
            if (n == 1)
            {
                IProgress progress = new ChangeStudent(); // ???
                Console.WriteLine("Ведите пердмет:");
                progress.AddProgress(lastName, SubjectChoise());
            }
        }

        private static int SubjectChoise()
        {
            int i=0;
            string[] items = new string[Subject.subject.Length];
            Console.WriteLine("Выберите дисциплину:");
            foreach ( string str in Subject.subject)
            {
                items[i] = str;
                i++;
            }
            ConsoleMenu menuSubject = new(items);
            return menuSubject.PrintMenu();
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
            string[] items = { "Выводим данные студента", "Выводим данные всех студентов" };
            ConsoleMenu menuShowStudent = new(items);
            int n = menuShowStudent.PrintMenu();
            if (n == 0)
            {
                Console.WriteLine("Ведите Фамилию:");
                string str = Console.ReadLine();
                show.ShowElement(str);
            }
            if (n == 1)
            {
                show.ShowAllElement();
            }
        }       
    }
}

﻿using CRUDInterface;

namespace Interface.lib
{
    public class TeacherMenu : ConsoleMenu
    {
        public TeacherMenu(string[] Items) : base(Items)
        {
        }

        public delegate void method();
        public static void MenuTeacher()
        {
            string[] items = { "Новый учитель", "Изменить данные учителя", "уволить учителя", "вернуться в предыдущее меню" };
            method[] methods = new method[] { CreateTeacher, ChangeTeacher, ExpelTeacher, ShowTeacher};
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
            string[] items = { "Выводим данные учителя", "Выводим данные всех учителей" };
            ConsoleMenu menuShowTeacher = new ConsoleMenu(items);
            int n = menuShowTeacher.PrintMenu();
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

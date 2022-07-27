using CRUD.lib;
using Interface.lib.CRUDInterface.FileInterface;

namespace CLI.lib
{
    public class Menu: ConsoleMenu
    {
        public delegate void method();
        public static bool tempStatus=false;

        public Menu(string[] Items) : base(Items)
        {
        }
        public static void StartProgram()
        {
            IFile temp = new PeopleFile();
            IFile progress = new ProgressFile();
            temp.WriteFile();
            progress.WriteFile();
            Program();
        }
        private static void Program()
        {
            if(tempStatus==false)
            {
                Temp temp;
                tempStatus=true;
            }
            string[] items = { "Меню Студентов", "Меню Учителей", "Меню Сотрудников", "Выход" };
            method[] methods = new method[] { MethodStudent, MethodTeacher, MethodStaff, Exit };
            ConsoleMenu menu = new(items);
            int menuResult;
            do
            {
                menuResult = menu.PrintMenu();
                methods[menuResult]();
                Console.WriteLine("Для продолжения нажмите любую клавишу");
                _ = Console.ReadKey();
            } while (menuResult != items.Length - 1);
        }

        private static void MethodStudent()
        {
            Console.WriteLine("Переходим в меню студентов");
            StudentMenu.MenuStudent();
        }

        private static void MethodTeacher()
        {
            Console.WriteLine("переходим в меню учителей");
            TeacherMenu.MenuTeacher();
        }

        private static void MethodStaff()
        {
            Console.WriteLine("переходим в меню сотрудников");
            StaffMenu.MenuStaff();
        }

        private static void Exit()
        {
            Console.WriteLine("Приложение заканчивает работу!");
            Environment.Exit(0);

        }
    }
}
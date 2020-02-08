using System;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ToDo list creator!");

            Option option = GetOption();

            while (option == Option.None)
            {
                Console.WriteLine("\r\nSorry that's not a valid option, please try again:");
                option = GetOption();
            }

            switch (option)
            {
                case Option.None:
                    break;
                case Option.Create:
                    CreateToDo();
                    break;
                default:
                    break;
            }

            Console.WriteLine("Press any key to exit");
            Console.Read();
        }

        /// <summary>
        /// Present the option(s) and return the users chosen option.
        /// </summary>
        /// <returns>An <see cref="Option"/> value indicaing what option the user has chosen.</returns>
        private static Option GetOption()
        {
            Option option = Option.None;

            Console.WriteLine("\r\nWhat would you like to do?");
            Console.WriteLine("1. Create a new ToDo");
            string input = Console.ReadLine();

            if (input == "1")
            {
                option = Option.Create;
            }

            return option;
        }

        /// <summary>
        /// Create a new ToDo item.
        /// </summary>
        private static void CreateToDo()
        {
            Console.WriteLine("\r\nAwesome, you want to create a new ToDo, let's get started...");

            Console.WriteLine("Title:");
            string title = Console.ReadLine();

            Console.WriteLine("Description:");
            string description = Console.ReadLine();

            ToDoItem item = new ToDoItem(title, description);

            Console.WriteLine($"\r\nGreat! You've just created a new ToDo with title: '{item.Title}' and descripton: '{item.Description}'.");
        }
    }
}

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
                    Console.WriteLine("\r\nAwesome, you want to create a new ToDo, let's get started...");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }

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
    }
}

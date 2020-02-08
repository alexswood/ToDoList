namespace ToDoList
{
    /// <summary>
    /// Provide functionality to manage the ToDo list.
    /// </summary>
    internal class ToDoListManager
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public ToDoListManager()
        {
        }

        /// <summary>
        /// Create a new ToDo item.
        /// </summary>
        public void CreateToDo(string title, string description)
        {
            ToDoItem item = new ToDoItem(title, description);
        }
    }
}
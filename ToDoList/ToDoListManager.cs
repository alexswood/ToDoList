namespace ToDoList
{
    /// <summary>
    /// Provide functionality to manage the ToDo list.
    /// </summary>
    internal class ToDoListManager
    {
        ToDoListStore store;
        ToDoItems items = new ToDoItems();

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="toDoListStore">The object used to store todo items.</param>
        public ToDoListManager(ToDoListStore toDoListStore)
        {
            store = toDoListStore;
        }

        /// <summary>
        /// Create and store a new ToDo item.
        /// </summary>
        public void CreateToDo(string title, string description)
        {
            ToDoItem item = new ToDoItem(title, description);
            items.Items.Add(item);

            store.Write(items);
        }
    }
}
namespace ToDoList
{
    /// <summary>
    /// Define funtionality to store a todo list.
    /// </summary>
    internal interface ToDoListStore
    {
        /// <summary>
        /// Add a todo item to the todo list store.
        /// </summary>
        /// <param name="toDoItem">The todo item to store.</param>
        void Add(ToDoItem toDoItem);
    }
}
namespace ToDoList
{
    /// <summary>
    /// Define funtionality to store a todo list.
    /// </summary>
    internal interface ToDoListStore
    {
        /// <summary>
        /// Write the todo items to the todo list store.
        /// </summary>
        /// <param name="toDoItem">The todo items to store.</param>
        void Write(ToDoItems toDoItem);
    }
}
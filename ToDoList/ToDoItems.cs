using System.Collections.Generic;

namespace ToDoList
{
    /// <summary>
    /// Define the structure of todo items.
    /// </summary>
    public class ToDoItems
    {
        /// <summary>
        /// Gets and sets a List of <see cref="ToDoItem"/>.
        /// </summary>
        public List<ToDoItem> Items { get; set; } = new List<ToDoItem>();
    }
}
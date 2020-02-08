namespace ToDoList
{
    /// <summary>
    /// Define the structure of a todo item.
    /// </summary>
    public class ToDoItem
    {
        /// <summary>
        /// Parameterless constructor for serialisation.
        /// </summary>
        public ToDoItem()
        {

        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="title">The title of the todo item.</param>
        /// <param name="description">The description of the todo item.</param>
        public ToDoItem(string title, string description)
        {
            Title = title;
            Description = description;
        }

        /// <summary>
        /// Gets the title of the todo item.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets the description of the todo item.
        /// </summary>
        public string Description { get; set; }
    }
}
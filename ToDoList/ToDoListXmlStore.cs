using System.IO;
using System.Xml.Serialization;

namespace ToDoList
{
    /// <summary>
    /// Define an implementation of the <see cref="ToDoListStore"/> that stores
    /// the todo list in an xml file.
    /// </summary>
    internal class ToDoListXmlStore : ToDoListStore
    {
        string filepath = @"C:\\store.xml";

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="storeLocation">The location of the xml store.</param>
        public ToDoListXmlStore(string storeFilepath)
        {
            filepath = storeFilepath;
            
            Directory.CreateDirectory(Path.GetDirectoryName(storeFilepath));
        }

        /// <summary>
        /// Write the todo items to file.
        /// </summary>
        /// <param name="items"></param>
        public void Write(ToDoItems items)
        {
            Serialise(items);
        }

        /// <summary>
        /// Serialise the given items into an xml document.
        /// </summary>
        /// <param name="item"></param>
        private void Serialise(ToDoItems item)
        {
            XmlSerializer serialiser = new XmlSerializer(typeof(ToDoItems));

            using (TextWriter writer = new StreamWriter(filepath))
            {
                serialiser.Serialize(writer, item);
            }
        }
    }
}
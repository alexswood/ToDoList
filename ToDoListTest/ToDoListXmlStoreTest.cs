using NUnit.Framework;
using System.IO;
using ToDoList;

namespace ToDoListTest
{
    [TestFixture]
    public class ToDoListXmlStoreTest
    {
        [Test]
        public void Write_XmlFileCreated()
        {
            // Given
            string title = "Test Title";
            string description = "Test Description";
            ToDoItem item = new ToDoItem(title, description);

            ToDoItems items = new ToDoItems();
            items.Items.Add(item);

            string filepath = @"C:\Test\store.xml";
            ToDoListXmlStore store = new ToDoListXmlStore(filepath);

            // When
            store.Write(items);

            // Then
            Assert.True(File.Exists(filepath));
        }
    }
}

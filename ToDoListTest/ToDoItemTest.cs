using NUnit.Framework;
using ToDoList;

namespace ToDoListTest
{
    [TestFixture]
    public class ToDoItemTest
    {
        [Test]
        public void ConstructToDoItem_HasCorrectPropertyValues()
        {
            // Given
            string title = "Test Title";
            string description = "Test Description";

            // When
            ToDoItem item = new ToDoItem(title, description);

            // Then
            Assert.AreEqual(title, item.Title);
            Assert.AreEqual(description, item.Description);
        }
    }
}

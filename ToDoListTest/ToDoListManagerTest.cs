using NSubstitute;
using NUnit.Framework;
using ToDoList;

namespace ToDoListTest
{
    [TestFixture]
    class ToDoListManagerTest
    {
        ToDoListStore mockToDoListStore = Substitute.For<ToDoListStore>();

        [Test]
        public void CreateToDo_ShouldCall_ToDoListStore_Write()
        {
            // Given
            string title = "test title";
            string description = "test description";
            ToDoListManager manager = new ToDoListManager(mockToDoListStore);

            // When
            manager.CreateToDo(title, description);

            // Then
            mockToDoListStore.Received(1).Write(
                Arg.Is<ToDoItems>(
                    x =>
                    x.Items.Count == 1 &&
                    x.Items[0].Title == title &&
                    x.Items[0].Description == description
                    )
                );
        }
    }
}

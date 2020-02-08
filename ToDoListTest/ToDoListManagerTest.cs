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
        public void CreateToDo_ShouldCall_ToDoListStore_Add()
        {
            // Given
            string title = "test title";
            string description = "test description";
            ToDoListManager manager = new ToDoListManager(mockToDoListStore);

            // When
            manager.CreateToDo(title, description);

            // Then
            mockToDoListStore.Received(1).Add(Arg.Is<ToDoItem>(x => x.Title == title && x.Description == description));
        }
    }
}

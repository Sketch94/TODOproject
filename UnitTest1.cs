using TODOproject;

namespace ToDoListTests
{
    public class ToDoListTests
    {
        private ToDoList _toDoList;

        public ToDoListTests()
        {
            _toDoList = new ToDoList();
        }   

        [Fact]
        public void AddTask_ShouldAddTaskToList()
        {
            var task = "Task 1";    
            _toDoList.Add(task);
            var tasks = _toDoList.GetListOfItems();
            Assert.Contains(task, tasks);
        }

        [Fact]
        public void RemoveTask_ShouldRemoveTaskFromList()
        {
            var task = "Task2Remove";
            _toDoList.Add(task);
            _toDoList.Remove(0);
            var tasks = _toDoList.GetListOfItems();
            Assert.DoesNotContain(task, tasks);
        }

        [Fact]
        public void RemoveTask_ShouldNotRemoveTaskFromList()
        {
            var task = "TaskNot2Remove";
            _toDoList.Add(task);
            _toDoList.Remove(10);
            var tasks = _toDoList.GetListOfItems();
            Assert.Single(task);
        }
    }
}
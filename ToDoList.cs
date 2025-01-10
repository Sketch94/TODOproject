using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TODOproject
{
    public class ToDoList
    {
        private List<string> _toDoList = new();

        public void Add(string item)
        {
            _toDoList.Add(item);
        }

        public void Remove(int index)
        {
            if (index >= 0 && index < _toDoList.Count)
            {
                _toDoList.RemoveAt(index);
            }
        }

       public List<string> GetListOfItems()
        {
            return _toDoList;
        }   
    }
}

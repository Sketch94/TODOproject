using System.Windows;

namespace TODOproject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ToDoList _toDoList;

        public MainWindow()
        {
            InitializeComponent();
            _toDoList = new ToDoList();

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string task = AddAssignment.Text;
            if (!string.IsNullOrEmpty(task))
            {
                _toDoList.Add(task);
                UpdateTaskSyle();
                AddAssignment.Clear();
            }
        }

        private void UpdateTaskSyle()
        {
            AssignmentList.Items.Clear();
            foreach (var task in _toDoList.GetListOfItems())
            {
                AssignmentList.Items.Add(task);
            }

        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (AssignmentList.SelectedIndex >= 0)
            {
                _toDoList.Remove(AssignmentList.SelectedIndex);
                UpdateTaskSyle();
            }
        }
    }
}
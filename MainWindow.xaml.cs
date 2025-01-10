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
            if (string.IsNullOrEmpty(task))
            {
                MessageBox.Show("Ingen uppgift angiven.", "Fel", MessageBoxButton.OK, MessageBoxImage.None);
                return;
            }
            else
            {
                MessageBox.Show("Uppgift tillagd.", "Lyckades", MessageBoxButton.OK, MessageBoxImage.Information);
                _toDoList.Add(task);
                UpdateTaskStyle();
                AddAssignment.Clear();
            }

        }

        private void UpdateTaskStyle()
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
                UpdateTaskStyle();
            }
        }
    }
}
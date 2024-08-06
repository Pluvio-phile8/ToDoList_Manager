using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using todolist.business;
using todolist.dao.Models;

namespace todolist.views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NoteRepository _repository;
        public MainWindow()
        {
            InitializeComponent();
            LoadNoteData();
        }
        public void LoadNoteData()
        {
            _repository = new();
            lvNotes.ItemsSource = _repository.GetAllNotes(); 
        }

        public void Add_Note(object sender, RoutedEventArgs e)
        {
            var selectedNote = lvNotes.SelectedItem as Note;
            var addNoteWindow = new AddNoteWindow();
            if (addNoteWindow.ShowDialog() == true)
            {
                LoadNoteData();
            }
        }
        private void OpenNote_Click(object sender, RoutedEventArgs e)
        {
            var selectedNote = lvNotes.SelectedItem as Note;
            if (selectedNote != null)
            {
                var addNoteWindow = new UpdateNoteWindow(selectedNote);
                if (addNoteWindow.ShowDialog() == true)
                {
                    LoadNoteData();
                }
            }
            else
            {
                MessageBox.Show("No note selected.");
            }
        }

        private void DeleteNote_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve the selected item from the DataGrid
            var selectedNote = lvNotes.SelectedItem as Note; // Replace Note with your actual data type

            if (selectedNote != null)
            {
                MessageBoxResult result = MessageBox.Show("Do you want to delete this note?", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    _repository.DeleteNote(selectedNote);
                    LoadNoteData();
                }
            }
            else
            {
                MessageBox.Show("No note selected.");
            }
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            string searchText = searchTextBox.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Search text cannot be empty!");
                return;
            }

            var list = _repository.SearchNote(searchText);

            if (list == null || !list.Any())
            {
                MessageBox.Show("No notes found matching the search criteria.");
                lvNotes.ItemsSource = _repository.GetAllNotes(); // Show all notes if no results
            }
            else
            {
                lvNotes.ItemsSource = list; // Display search results
            }
        }

        private void Sort1_Click(object sender, RoutedEventArgs e)
        {
            
            lvNotes.ItemsSource = _repository.SortLatestDate();
        }

        private void Sort2_Click(object sender, RoutedEventArgs e)
        {
            lvNotes.ItemsSource = _repository.SortOldestDate();
        }
    }
}
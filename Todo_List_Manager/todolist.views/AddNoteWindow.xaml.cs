using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using todolist.business;
using todolist.dao.Models;

namespace todolist.views
{
    /// <summary>
    /// Interaction logic for AddNoteWindow.xaml
    /// </summary>
    public partial class AddNoteWindow : Window
    {
        private readonly INoteRepository? noteRepository;

        public AddNoteWindow()
        {
            InitializeComponent();
            noteRepository = new NoteRepository();
        }

        private void Save_Button(object sender, RoutedEventArgs e)
        {
            string content = NoteContent.Text;
            var today = DateOnly.FromDateTime(DateTime.Now);
            if (string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Note content cannot be empty.");
                return;
            }
            Note note = new();
            note.Description = content;
            note.CreateAt = today;
            try
            {
                noteRepository.AddNote(note);
                MessageBox.Show("Added Successfully!");
                DialogResult = true;
            } catch(Exception ex)
            {
                DialogResult = false;
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Cancel_Button(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

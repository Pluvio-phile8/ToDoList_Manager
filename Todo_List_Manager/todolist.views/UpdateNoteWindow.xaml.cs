using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
    /// Interaction logic for UpdateNoteWindow.xaml
    /// </summary>
    public partial class UpdateNoteWindow : Window
    {
        private readonly INoteRepository? noteRepository;
        private Note _note;
        public UpdateNoteWindow(Note note)
        {
            InitializeComponent();
            noteRepository = new NoteRepository();
            _note = note;
            if (note != null)
            {
                NoteContent.Text = note.Description;
                NoteId.Text = note.Id.ToString();
            }
        }

        private void Save_Button(object sender, RoutedEventArgs e)
        {
            var newContent = NoteContent.Text;
            if (string.IsNullOrEmpty(newContent))
            {
                MessageBox.Show("Note content cannot be empty.");
                return;
            }
            var updatedDate = DateOnly.FromDateTime(DateTime.Now);
            var noteId = int.Parse(NoteId.Text);
            var newNote = new Note();
            newNote.Id = noteId;
            newNote.Description = newContent;
            newNote.CreateAt = updatedDate;
            newNote.Status = false;
            try
            {
                noteRepository.UpdateNote(newNote);
                MessageBox.Show("Updated Successfully!");
                DialogResult = true;
            } catch (Exception ex)
            {
                DialogResult = false;
                Console.WriteLine(ex.ToString());
            }
        }

        private void Delete_Button(object sender, RoutedEventArgs e)
        {
           
            if (_note != null)
            {
                MessageBoxResult result = MessageBox.Show("Do you want to delete this note?", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    try
                    {
                        noteRepository.DeleteNote(_note);
                        MessageBox.Show("Deleted Successfully!");
                        DialogResult = true;
                    } catch (Exception ex)
                    {
                        DialogResult = false;
                        Console.WriteLine(ex.ToString());
                    }
                  
                }
            }
        }
    }
}

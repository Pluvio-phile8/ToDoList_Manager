using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todolist.dao.Models;

namespace todolist.business
{
    public interface INoteRepository
    {
        List<Note> GetAllNotes();
        void AddNote(Note note);
        void DeleteNote(Note note);
        void UpdateNote(Note note);
        List<Note> SearchNote(string text);
        List<Note> SortLatestDate();
        List<Note> SortOldestDate();
    }
}

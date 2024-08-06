using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todolist.dao.Controller;
using todolist.dao.Models;

namespace todolist.business
{
    public class NoteRepository : INoteRepository
    {
        private readonly NoteDao? noteDao;
        public NoteRepository()
        {
            noteDao = new NoteDao();
        }
        public void AddNote(Note note) => noteDao.AddNote(note);
        public void DeleteNote(Note note) => noteDao.DeleteNote(note);
        public List<Note> GetAllNotes() => noteDao.GetAllNotes();

        public List<Note> SearchNote(string text) => noteDao.SearchNote(text);

        public List<Note> SortLatestDate() => noteDao.SortByLatestDate();


        public List<Note> SortOldestDate() => noteDao.SortByOldestDate();
        

        public void UpdateNote(Note note) => noteDao.UpdateNote(note);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using todolist.dao.Models;
using static System.Net.Mime.MediaTypeNames;

namespace todolist.dao.Controller
{
    public class NoteDao
    {
        private ToDoListContext _context;

        public NoteDao() { }
        public List<Note> GetAllNotes()
        {
            _context = new();
            try
            {
                return _context.Notes.ToList();
            } 
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while retrieving tasks: {ex.Message}");
                return new List<Note>();
            }
        }
        public void AddNote(Note note)
        {
            _context = new();
            try
            {
                _context.Notes.Add(note);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void DeleteNote(Note note)
        {
            _context = new();
            try
            {
                _context.Notes.Remove(note);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void UpdateNote(Note note)
        {
            _context = new();
            try
            {
                _context.Notes.Update(note);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public List<Note> SearchNote(string text)
        {
            _context = new();
            try
            {
                return _context.Notes.Where(n => n.Description.ToLower().Contains(text)).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return new List<Note>();
        }
        public List<Note> SortByLatestDate()
        {
            _context = new();
            try
            {
                return _context.Notes.OrderByDescending(n => n.CreateAt).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return new List<Note>();
        }
        public List<Note> SortByOldestDate()
        {
            _context = new();
            try
            {
                return _context.Notes.OrderBy(n => n.CreateAt).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return new List<Note>();
        }
    }
}

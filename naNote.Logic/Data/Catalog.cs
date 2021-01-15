using naNote.Logic.Model;
using System.Collections.Generic;
using naNote.Logic;

namespace naNote.Logic.Data
{
    public class Catalog
    {
        public List<Category> CategoryList { get; set; }
        public List<Diary> DiaryList { get; set; }
        public List<Note> NoteList { get; set; }

        public Catalog()
        {
            CategoryList = new List<Category>();
            DiaryList = new List<Diary>();
            NoteList = new List<Note>();
        }
        
    }
}

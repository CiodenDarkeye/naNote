using Nanote.Logic.Model;
using System.Collections.Generic;
using Nanote.Logic;

namespace Nanote.Logic.Data
{
    public class Catalog
    {
        public List<Category> CategoryList { get; set; }
        public List<Diary> DiaryList { get; set; }
        public List<Note> NoteList { get; set; }

        public Catalog(bool filler)
        {
            // debug mode, which adds filler data
            CategoryList = new List<Category>();
            DiaryList = new List<Diary>();
            NoteList = new List<Note>();

            CategoryList.Add(new Category(){Name="Work"});
            CategoryList.Add(new Category(){Name="Personal"});
            CategoryList.Add(new Category(){Name="Cooking"});
        }
        public Catalog()
        {
            CategoryList = new List<Category>();
            DiaryList = new List<Diary>();
            NoteList = new List<Note>();
        }
        
    }
}

using Nanote.Logic.Model;
using System.Collections.Generic;
using Nanote.Logic;

namespace Nanote.Logic.Data
{
    public class Catalog
    {
        public List<Category> categoryList { get; set; }
        public List<Diary> diaryList { get; set; }
        public List<Note> noteList { get; set; }
        public Catalog(bool filler)
        {
            // debug mode, which adds filler data
            categoryList = new List<Category>();
            diaryList = new List<Diary>();
            noteList = new List<Note>();

            categoryList.Add(new Category(){Name="Work"});
            categoryList.Add(new Category(){Name="Personal"});
            categoryList.Add(new Category(){Name="Cooking"});
        }
        public Catalog()
        {
            categoryList = new List<Category>();
            diaryList = new List<Diary>();
            noteList = new List<Note>();
        }
        
    }
}

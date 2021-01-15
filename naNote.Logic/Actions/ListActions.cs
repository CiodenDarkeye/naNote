using naNote.Logic.Data;
using naNote.Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naNote.Logic.Actions
{
    public class ListActions
    {
        public static List<string> List(Catalog catalog, string payload)
        {
            switch (payload)
            {
                case "diary":
                    return ListDiaries(catalog);
                case "note":
                    return ListNotes(catalog);
                case "category":
                    return ListCategories(catalog);
                default:
                    // Not yet implemented
                    throw new NotImplementedException();
            }
        }
        private static List<string> ListDiaries(Catalog catalog)
        {
            var retList = new List<String>();
            //Returning the last 10 diaries

            foreach (Diary diary in catalog.DiaryList.TakeLast(10))
            {
                retList.Add($"Entry #{diary.Id}, created at {diary.CreatedDtime.ToShortDateString()}\n" +
                    $"{diary.Entry}");
            }

            return retList;
        }

        private static List<string> ListNotes(Catalog catalog)
        {
            var retList = new List<string>();

            foreach (Note note in catalog.NoteList.TakeLast(10))
            {
                retList.Add($"Entry #{note.Id} at {note.CreatedDtime.ToShortDateString()}" +
                    $"{note.Entry}");
            }

            return retList;
        }

        private static List<string> ListCategories(Catalog catalog)
        {
            var retList = new List<string>();
            foreach (var category in catalog.CategoryList.TakeLast(10))
            {
                retList.Add($"Entry #{category.Id} at {category.CreatedDtime.ToShortDateString()}" +
                    $"{category.Name}");
            }
            return retList;
        }
    }

 
}

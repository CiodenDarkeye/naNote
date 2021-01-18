using naNote.Logic.Model;
using System.Collections.Generic;
using naNote.Logic;
using System;
using System.Linq;
using System.Collections;

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

        public void AddDiary(HashSet<int> categories,String payload)
        {
            // Check to see if there's an existing diary already today
            if (DiaryList.Any(p => p.CreatedDtime.Date == DateTime.Today))
            {
                // If there is an existing diary, append to it.
                var diaryToEdit = DiaryList.Last(p => p.CreatedDtime.Date == DateTime.Today);
                diaryToEdit.CategoryIDs.UnionWith(categories);
                diaryToEdit.Entry += $"\n{DateTime.Now.ToShortTimeString()}: {payload}";
            }
            else
            {
                // If there isn't, make a new one.
                var newEntry = new Diary()
                {
                    Entry = $"Diary: {DateTime.Now.ToShortDateString()}\n\n{DateTime.Now.ToShortTimeString()}: {payload}"
                };
                newEntry.CategoryIDs.UnionWith(categories);
                DiaryList.Add(newEntry);
            }
        }

        public void AddNote(HashSet<int> categories, string payload)
        {
            var newEntry = new Note()
            {
                Entry = payload,
            };
            newEntry.CategoryIDs.AddRange(categories);
            NoteList.Add(newEntry);
        }

        public List<string> ListText(string action)
        {
            List<string> _retList = new List<string>();
            // TODO: Figure out how I can make this list more of an ongoing iterable thing.
            switch(action)
            {
                case "diary":
                    foreach (Diary diary in DiaryList.TakeLast(10))
                    {
                        _retList.Add($"Entry #{diary.Id}, created at {diary.CreatedDtime.ToShortDateString()}\n" +
                            $"{diary.Entry}");
                    }
                    break;
                case "note":
                    foreach (Note note in NoteList.TakeLast(10))
                    {
                        _retList.Add($"Entry #{note.Id} at {note.CreatedDtime.ToShortDateString()}" +
                            $"{note.Entry}");
                    }
                    break;
                case "category":
                    foreach (var category in CategoryList.TakeLast(10))
                    {
                        _retList.Add($"Entry #{category.Id} at {category.CreatedDtime.ToShortDateString()}" +
                            $"{category.Name}");
                    }
                    break;
                default:
                    break;
            }
            return _retList;
        }

    }
}

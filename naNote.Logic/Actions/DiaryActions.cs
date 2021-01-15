using naNote.Logic.Data;
using naNote.Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naNote.Logic.Actions
{
    public static class DiaryActions
    {
        public static void AddDiary(
            Catalog catalog,
            HashSet<int> categories,
            String payload)
        {
            // Check to see if there's an existing diary already today

            if (catalog.DiaryList.Any(p => p.CreatedDtime.Date == DateTime.Today))
            {
                // If there is an existing diary, append to it.
                var diaryToEdit = catalog.DiaryList.Last(p => p.CreatedDtime.Date == DateTime.Today);
                diaryToEdit.CategoryIDs.UnionWith(categories);
                diaryToEdit.Entry += $"\n{DateTime.Now.ToShortTimeString()}: {payload}";
            }
            else
            {
                // If there isn't, make a new one.
                var newEntry = new Diary() {
                    Entry = $"Diary: {DateTime.Now.ToShortDateString()}\n\n{DateTime.Now.ToShortTimeString()}: {payload}" 
                };
                newEntry.CategoryIDs.UnionWith(categories);
                catalog.DiaryList.Add(newEntry);
            }   
        }
    }
}
using Nanote.Logic.Data;
using Nanote.Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanote.Logic.Actions
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
                var diaryToEdit = catalog.DiaryList.Last(p => p.CreatedDtime.Date == DateTime.Today);
                diaryToEdit.CategoryIDs.UnionWith(categories);
                diaryToEdit.Entry += $"\n{DateTime.Now.ToShortDateString()}: {payload}";
            }
            else
            {
                var newEntry = new Diary() {Entry = $"{DateTime.Now.ToShortDateString()}: {payload}" };
                newEntry.CategoryIDs.UnionWith(categories);
                catalog.DiaryList.Add(newEntry);
            }   
        }
    }
}
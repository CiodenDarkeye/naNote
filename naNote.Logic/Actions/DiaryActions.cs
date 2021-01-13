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
            List<int> categories,
            String payload)
        {
            var newEntry = new Diary()
            {
                Entry = payload,
            };
            newEntry.CategoryIDs.AddRange(categories);
            catalog.DiaryList.Add(newEntry);
        }
    }
}

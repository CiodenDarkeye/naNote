using Nanote.Logic.Data;
using Nanote.Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanote.Logic.Actions
{
    public static class NoteActions
    {
        public static void AddNote(
            Catalog catalog, 
            List<int> categories,
            String payload)
        {
            var newEntry = new Note()
            {
                Entry = payload,
            };
            newEntry.CategoryIDs.AddRange(categories);
            catalog.NoteList.Add(newEntry);
        }
    }
}

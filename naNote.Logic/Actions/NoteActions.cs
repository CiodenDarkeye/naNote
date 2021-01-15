using naNote.Logic.Data;
using naNote.Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naNote.Logic.Actions
{
    public static class NoteActions
    {
        public static void AddNote(
            Catalog catalog,
            HashSet<int> categories,
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

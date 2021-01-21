using System;
using System.Collections.Generic;

namespace naNote.Logic.Model
{
    public class Diary : BaseEntry
    {
        public HashSet<int> CategoryIDs { get; set; }
        public List<string> Entries
        {
            get { return entries; }
            private set { }
        }
        public int Id { get; private set; }
        public DateTime ModifiedDTime { get; private set; }

        private List<string> entries;
        private static int Id_value = 0;

        public Diary()
        {
            CategoryIDs = new HashSet<int>();
            entries = new List<string>();

            Id = Id_value;
            Id_value++;
        }
    }
}
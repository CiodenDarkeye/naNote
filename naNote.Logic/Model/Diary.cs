using System;
using System.Collections.Generic;

namespace naNote.Logic.Model
{
    public class Diary : BaseEntry
    {
        public HashSet<int> CategoryIDs { get; set; }
        public string Entry
        {
            get { return entry; }
            set
            {
                entry = value;
                ModifiedDTime = DateTime.Now;
            }
        }
        public int Id { get; private set; }
        public DateTime ModifiedDTime { get; private set; }

        private string entry;
        private static int Id_value = 0;

        public Diary()
        {
            CategoryIDs = new HashSet<int>();

            Id = Id_value;
            Id_value++;
        }
    }
}
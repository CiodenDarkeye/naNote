using System.Collections.Generic;

namespace naNote.Logic.Model
{
    public class Note : BaseEntry
    {
        public List<int> CategoryIDs{ get; set; }
        public string Entry { get; set; }
        public int Id { get; private set; }
        private static int Id_value = 0;
        public Note()
        {
            CategoryIDs = new List<int>();
            Id = Id_value;
            Id_value++;
        }
    }
}
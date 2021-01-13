using System.Collections.Generic;

namespace Nanote.Logic.Model
{
    public class Diary: BaseEntry
    {
        public List<int> CategoryIDs{ get; set; }
        public string Entry { get; set; }

        public Diary()
        {
            CategoryIDs = new List<int>();
        }
    }
}
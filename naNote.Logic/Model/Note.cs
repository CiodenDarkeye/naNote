using System.Collections.Generic;

namespace Nanote.Logic.Model
{
    public class Note
    {
        public List<int> CategoryIDs{ get; set; }
        public string Entry { get; set; }
        public Note()
        {
            CategoryIDs = new List<int>();
        }
    }
}
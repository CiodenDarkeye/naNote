using System.Collections.Generic;

namespace Nanote.Logic.Model
{
    public class Diary: BaseEntry
    {
        public List<Category> Categories { get; set; }
        public string Entry { get; set; }

        public Diary()
        {
            Categories = new List<Category>();
        }
    }
}
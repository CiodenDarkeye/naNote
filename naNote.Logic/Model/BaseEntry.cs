using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanote.Logic.Model
{
    public class BaseEntry
    {
        public int Id { get; private set; }
        public DateTime CreatedDtime { get; private set; }

        static int id_value = 0;

        public BaseEntry()
        {
            Id = id_value;
            id_value++;
            CreatedDtime = DateTime.Now;
        }

    }
}

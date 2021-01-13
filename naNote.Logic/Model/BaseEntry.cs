using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanote.Logic.Model
{
    public class BaseEntry
    {
        public DateTime CreatedDtime { get; private set; }

        public BaseEntry()
        {
            CreatedDtime = DateTime.Now;
        }

    }
}

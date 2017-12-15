using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDict.Admin.Entity
{
    public class Language
    {
        public uint ID { get; set; } 
        public string Name { get; set; }
        public string Title { get; set; }

        public Language()
        {
            ID = 0;
            Name = string.Empty;
            Title = string.Empty;
        }
    }
}

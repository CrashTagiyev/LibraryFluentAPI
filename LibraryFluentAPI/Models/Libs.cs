using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFluentAPI.Models
{
    public class Libs:BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        //navigation property
        public List<TCards> TCards { get; set; }
        public List<SCards> SCards { get; set; }
    }
}

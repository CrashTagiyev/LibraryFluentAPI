using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFluentAPI.Models
{
    public class Students : BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Term { get; set; }

        //Foreign keys
        public int GroupsId { get; set; }
        //Navigation Property
        public Groups Group { get; set; }
        public List<SCards> SCards { get; set; }
    }
}

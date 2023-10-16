using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFluentAPI.Models
{
    public class Authors: BaseEntity
    {
        public string Fistname { get; set; }
        public string Lastname { get; set; }


        //Navigation Properties
        public List<Books> Books { get; set; }
    }
}

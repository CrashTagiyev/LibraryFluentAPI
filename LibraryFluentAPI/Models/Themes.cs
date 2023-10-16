using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFluentAPI.Models
{
    public class Themes: BaseEntity
    {
        public string Name { get; set; }


        //Navigation Property
        public List<Books> Books { get; set; }
    }
}

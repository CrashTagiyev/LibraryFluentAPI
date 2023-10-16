using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFluentAPI.Models
{
    public class Press: BaseEntity
    {
        public string Name {  get; set; }
        
        //NavigationProperty
        public List<Books> Books { get; set; }
    }
}

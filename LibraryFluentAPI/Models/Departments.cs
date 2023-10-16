using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFluentAPI.Models
{
    public class Departments:BaseEntity
    {
        public string Name { get; set; }

        //Navigation properties
        public List<Teachers> Teachers { get; set; }

     
    }
}

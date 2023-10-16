using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFluentAPI.Models
{
    public class Groups:BaseEntity
    {
        public string Name { get; set; }

        //Foreign key
        public int FacultyId { get; set; }
        //Navigation property
        public Faculties Faculty { get; set; }
        public List<Students> Students { get; set; }   
    }
}

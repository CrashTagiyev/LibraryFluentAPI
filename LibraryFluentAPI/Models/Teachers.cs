using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFluentAPI.Models
{
    public class Teachers:BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        //Foreign keys
        public int DepartmentId { get; set; }

        //Navigation Property
        public List<TCards> TCards { get; set; }
        public Departments Department { get; set; }
    }
}

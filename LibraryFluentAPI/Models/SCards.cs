using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFluentAPI.Models
{
    public class SCards:BaseEntity
    {
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }

        //Foreign keys
        public int StudentsId { get; set; }
        public int BooksId { get; set; }
        public int LibsId { get; set; }
        
        //Navigation Property
        public Students Teacher { get; set; }
        public Books Book { get; set; }
        public Libs Lib { get; set; }
    }
}

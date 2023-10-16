using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFluentAPI.Models
{
    public class Books: BaseEntity
    {
        public string Name { get; set; }
        public int Pages { get; set; }
        public string? Comment { get; set; }
        public int Quantity { get; set; }


        //Foreign Keys
        public int ThemesId { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public int PressId { get; set; }

        //Navigation Properties
        public Themes Theme { get; set; }
        public Categories Category { get; set; }
        public Authors Author { get; set; }
        public Press Press { get; set; }



    }
}

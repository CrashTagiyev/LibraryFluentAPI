namespace LibraryFluentAPI.Models
{
    public class Faculties:BaseEntity
    {
        public string Name { get; set; }

        //Navigation Property
        public List<Groups> Groups { get; set; }
    }
}

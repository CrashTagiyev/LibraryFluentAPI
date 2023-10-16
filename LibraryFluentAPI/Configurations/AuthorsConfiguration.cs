using LibraryFluentAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryFluentAPI.Configurations
{
    public class AuthorsConfiguration : IEntityTypeConfiguration<Authors>
    {
   
        public void Configure(EntityTypeBuilder<Authors> builder)
        {
            
        }
    }
}

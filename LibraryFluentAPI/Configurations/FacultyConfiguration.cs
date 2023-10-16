using LibraryFluentAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryFluentAPI.Configurations
{
    public class FacultyConfiguration : IEntityTypeConfiguration<Faculties>
    {
        public void Configure(EntityTypeBuilder<Faculties> builder)
        {
            //Constraints
            builder.Property(p=>p.Name).IsRequired().HasMaxLength(20);

            //Navigations
            builder.HasMany<Groups>()
                .WithOne().HasForeignKey(g => g.FacultyId);

        }
    }
}

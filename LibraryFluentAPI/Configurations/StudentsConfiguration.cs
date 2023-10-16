using LibraryFluentAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryFluentAPI.Configurations
{
    internal class StudentsConfiguration : IEntityTypeConfiguration<Students>
    {
        public void Configure(EntityTypeBuilder<Students> builder)
        {
            //Constraints
            builder.Property(p=>p.Firstname).IsRequired().HasMaxLength(20);
            builder.Property(p=>p.Lastname).IsRequired().HasMaxLength(20);

            //Navigations
            builder.HasMany<SCards>()
                .WithOne().HasForeignKey(sc => sc.StudentsId);
        }
    }
}

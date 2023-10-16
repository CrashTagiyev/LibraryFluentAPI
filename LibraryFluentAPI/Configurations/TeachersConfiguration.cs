using LibraryFluentAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFluentAPI.Configurations
{
    public class TeachersConfiguration : IEntityTypeConfiguration<Teachers>
    {
        public void Configure(EntityTypeBuilder<Teachers> builder)
        {
            builder.Property(x => x.Firstname).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Lastname).IsRequired().HasMaxLength(10);
            builder.HasMany<TCards>()
                .WithOne().HasForeignKey(T => T.TeacherId);
        }
    }
}

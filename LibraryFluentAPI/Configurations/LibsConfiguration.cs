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
    public class LibsConfiguration : IEntityTypeConfiguration<Libs>
    {
        public void Configure(EntityTypeBuilder<Libs> builder)
        {
            //Constraints
            builder.Property(p=>p.Firstname).IsRequired().HasMaxLength(15);
            builder.Property(p=>p.Lastname).IsRequired().HasMaxLength(15);

            //Navigations
            builder.HasMany<TCards>()
                .WithOne().HasForeignKey(l => l.LibsId);

            builder.HasMany<SCards>()
                .WithOne().HasForeignKey(l => l.LibsId);

        }
    }
}

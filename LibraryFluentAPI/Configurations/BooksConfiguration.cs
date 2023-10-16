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
    internal class BooksConfiguration : IEntityTypeConfiguration<Books>
    {
        public void Configure(EntityTypeBuilder<Books> builder)
        {
            ////Navigation properti ile
            //builder.HasOne(x=>x.Author).WithMany(x=>x.Books).HasForeignKey(x=>x.AuthorId);
            //builder.HasOne(x => x.Theme).WithMany(x => x.Books).HasForeignKey(x=>x.ThemesId);
            //builder.HasOne(x=>x.Press).WithMany(x => x.Books).HasForeignKey(x=>x.PressId);

            //Navigation propertisiz
            builder.HasOne<Authors>()
                .WithMany().HasForeignKey(x => x.AuthorId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne<Themes>()
                .WithMany().HasForeignKey(x => x.ThemesId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne<Press>()
                .WithMany().HasForeignKey(x => x.PressId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}

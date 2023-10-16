using LibraryFluentAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryFluentAPI.Configurations
{
    public class GroupsConfiguration : IEntityTypeConfiguration<Groups>
    {
        public void Configure(EntityTypeBuilder<Groups> builder)
        {
            builder.HasMany<Students>()
                .WithOne().HasForeignKey(g => g.GroupsId);
        }
    }
}

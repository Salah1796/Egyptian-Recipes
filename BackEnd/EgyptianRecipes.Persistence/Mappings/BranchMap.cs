#region Using ...
using EgyptianRecipes.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
#endregion
namespace EgyptianRecipes.Persistence.Repositories.Mappings
{
    public class BranchMap : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Branch>
    {
        #region Methods
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            #region Configure Fields
            builder.Property(prop => prop.Title).HasMaxLength(200);
            builder.Property(prop => prop.ManagerName).HasMaxLength(250);
            #endregion
        }
        #endregion
    }
}

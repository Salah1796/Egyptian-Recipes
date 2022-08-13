#region Using ...
using EgyptianRecipes.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
#endregion
namespace EgyptianRecipes.Persistence.Repositories.Mappings
{
    public class ManagerMap : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Manager>
    {
        #region Methods
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            #region Configure Fields
            builder.Property(prop => prop.Name).HasMaxLength(250);
            #endregion
        }
        #endregion
    }
}

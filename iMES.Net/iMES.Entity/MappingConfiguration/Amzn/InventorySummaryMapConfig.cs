using iMES.Entity.MappingConfiguration;
using iMES.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iMES.Entity.MappingConfiguration
{
    public class InventorySummaryMapConfig : EntityMappingConfiguration<InventorySummary>
    {
        public override void Map(EntityTypeBuilder<InventorySummary>
            builderTable)
        {
            //b.Property(x => x.StorageName).HasMaxLength(45);
        }
    }
}
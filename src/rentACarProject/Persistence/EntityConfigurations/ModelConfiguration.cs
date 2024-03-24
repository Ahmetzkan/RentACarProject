using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class ModelConfiguration : IEntityTypeConfiguration<Model>
{
    public void Configure(EntityTypeBuilder<Model> builder)
    {
        builder.ToTable("Models").HasKey(m => m.Id);

        builder.Property(m => m.Id).HasColumnName("Id").IsRequired();
        builder.Property(m => m.BrandId).HasColumnName("BrandId");
        builder.Property(m => m.FuelId).HasColumnName("FuelId");
        builder.Property(m => m.TransmissionId).HasColumnName("TransmissionId");
        builder.Property(m => m.Name).HasColumnName("Name");
        builder.Property(m => m.DailyPrice).HasColumnName("DailyPrice");
        builder.Property(m => m.ImageUrl).HasColumnName("ImageUrl");
        builder.Property(m => m.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(m => m.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(m => m.DeletedDate).HasColumnName("DeletedDate");

        builder.HasOne(m=>m.Brand);
        builder.HasOne(m=>m.Fuel);

        builder.HasQueryFilter(m => !m.DeletedDate.HasValue);
    }
}
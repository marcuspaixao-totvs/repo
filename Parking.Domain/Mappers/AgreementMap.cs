using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Mappers
{
    public class AgreementMap : IEntityTypeConfiguration<Agreement>
    {
        public void Configure(EntityTypeBuilder<Agreement> builder)
        {
            builder.ToTable("Agreement");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(200).HasColumnType("varchar(120)");
            builder.Property(x => x.DiscountAmount).IsRequired().HasMaxLength(50).HasColumnType("money");
            builder.Property(x => x.DiscountPercentage).IsRequired().HasMaxLength(250).HasColumnType("money");
        }
    }
}

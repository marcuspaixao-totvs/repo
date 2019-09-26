
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Mappers
{
    public class RateMap : IEntityTypeConfiguration<Rate>
    {
        public void Configure(EntityTypeBuilder<Rate> builder)
        {

            builder.ToTable("Rate");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).IsRequired().HasMaxLength(200).HasColumnType("varchar(10)");
            builder.Property(x => x.Description).IsRequired().HasMaxLength(200).HasColumnType("varchar(200)");
            builder.Property(x => x.DailyAmount).IsRequired().HasMaxLength(50).HasColumnType("money");
            builder.Property(x => x.OverNightAmount).HasColumnType("money");
            builder.Property(x => x.PeriodAmount).HasColumnType("money");
        }
    }

}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Mappers
{
    public class AssociateMap : IEntityTypeConfiguration<Associate>
    {
        public void Configure(EntityTypeBuilder<Associate> builder)
        {
            builder.ToTable("Associate");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.VacancyQuantity).IsRequired().HasColumnType("int");
            builder.Property(x => x.AgreementId).IsRequired();
            builder.Property(x => x.AgreementId).IsRequired();
            builder.Property(x => x.RateId).IsRequired();
        }
    }
}

using Entity4.SystemEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity4.AreaEntityContext
{
    class CountryConfigurationOption : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder
               .HasKey(t => t.id);

            builder
                .Property(t => t.Names)
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            
        }
    }
}

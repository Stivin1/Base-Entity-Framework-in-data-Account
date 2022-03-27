using Entity4.SystemEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity4.AreaEntityContext
{
    class ThemeConfigurationOption : IEntityTypeConfiguration<Theme>
    {
        public void Configure(EntityTypeBuilder<Theme> builder)
        {
            builder
                .HasKey(t => t.id);

            builder
                .Property(t => t.Name)
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);
        }
    }
}

using Entity4.SystemEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity4.AreaEntityContext
{
    class AddresSentConfigurationOption : IEntityTypeConfiguration<AddresSent>
    {
        public void Configure(EntityTypeBuilder<AddresSent> builder)
        {
            builder
               .HasKey(t => t.id);

            builder
                .Property(t => t.DateCreate)
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200);

            builder
                .HasOne(t => t.Message)
                .WithOne(t => t.AddresSent)
                .HasForeignKey<AddresSent>(t => t.MessageId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

using Entity4.SystemEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity4.AreaEntityContext
{
    class MessageConfigurationOption : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder
                .HasKey(t => t.id);

            builder
                .Property(t => t.MessageText)
                .HasColumnType("nvarchar(2000)")
                .HasMaxLength(2000);
            builder
                .Property(t => t.DateCreate)
                .HasColumnType("nvarchar(2000)")
                .HasMaxLength(2000);

            builder
                .Property(t => t.IsRead)
                .HasColumnType("bit")
                .HasMaxLength(1);

            builder
                .Property(t => t.IsHidden)
                .HasColumnType("bit")
                .HasMaxLength(1);

            builder
                .HasOne(t => t.Theme)
                .WithOne(t => t.Message)
                .HasForeignKey<Message>(t => t.ThemeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

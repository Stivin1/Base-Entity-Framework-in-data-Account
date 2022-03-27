using Entity4.SystemEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity4.AreaEntityContext
{
    class ProfileConfigurationOption : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder
                .HasKey(t => t.id);

            builder
                .Property(t => t.Name)
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);


            builder
                .HasOne(t => t.Pol)
                .WithMany(t => t.Profile)
                .HasForeignKey(t => t.PolId);

            builder
                .HasOne(t => t.User)
                .WithOne(t => t.Profile)
                .HasForeignKey<Profile>(t => t.UserId);

        }
    }
}

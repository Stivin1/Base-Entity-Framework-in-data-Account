using Entity4.SystemEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity4.AreaEntityContext
{
    class UserConfigurationOption : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(t => t.id);

            builder
                .Property(t => t.Name)
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30);

            builder
                .Property(t => t.Password)
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder
                .HasOne(t => t.Country)
                .WithMany(t => t.Users)
                .HasForeignKey(t => t.CountryId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(t => t.Role)
                .WithMany(t => t.Users)
                .UsingEntity<RoleIntermediate>
                (
                    t => t
                    .HasOne(t => t.Role)
                    .WithMany(t => t.RoleIntermediates)
                    .HasForeignKey(t => t.RoleId),

                    t => t
                    .HasOne(t => t.User)
                    .WithMany(t => t.RoleIntermediates)
                    .HasForeignKey(t => t.UserId),

                    j =>
                    {
                        j.HasKey(t => new { t.UserId, t.RoleId });
                        j.ToTable("RoleIntermediate");
                    }

                );

            builder
                .HasMany(t => t.Groups)
                .WithMany(t => t.Users)
                .UsingEntity<GroupsIntermediate>
                (
                    t => t
                    .HasOne(t => t.Groups)
                    .WithMany(t => t.GroupsIntermediates)
                    .HasForeignKey(t => t.GroupsId),

                    t => t
                    .HasOne(t => t.User)
                    .WithMany(t => t.GroupsIntermediates)
                    .HasForeignKey(t => t.UserId),

                    j =>
                    {
                        j.HasKey(t => new { t.GroupsId, t.UserId });
                        j.ToTable("GroupsIntermediate");
                    }

                );
        }
    }
}

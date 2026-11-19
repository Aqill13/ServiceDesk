using Domain.Features.Organization.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceDesk.Domain.Features.Identity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Configurations
{
    public class DepartmentMembershipConfiguration : IEntityTypeConfiguration<DepartmentMembership>
    {
        public void Configure(EntityTypeBuilder<DepartmentMembership> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => new { x.DepartmentId, x.UserId })
                .IsUnique()
                .HasFilter("[IsActive] = 1");

            builder.HasOne(x => x.Department)
                .WithMany()
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<User>()
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

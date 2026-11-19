using Domain.Features.Organization.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceDesk.Domain.Features.Identity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Configurations
{
    public class TeamMembershipConfiguration : IEntityTypeConfiguration<TeamMembership>
    {
        public void Configure(EntityTypeBuilder<TeamMembership> builder)
        {
            builder.HasKey(tm => tm.Id);

            builder.HasOne(tm => tm.Team)
                .WithMany()
                .HasForeignKey(tm => tm.TeamId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<User>()
                .WithMany()
                .HasForeignKey(tm => tm.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

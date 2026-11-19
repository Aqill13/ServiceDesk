using Domain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Features.Organization.Entities
{
    public class TeamMembership : BaseEntity
    {
        public Guid TeamId { get; private set; }
        public Guid UserId { get; private set; }
        public Team Team { get; private set; } = null!;
        public bool IsActive { get; private set; } = true;
        public DateTime JoinedAt { get; private set; } = DateTime.UtcNow;
        public DateTime? LeftAt { get; private set; }
        private TeamMembership() { }
        public TeamMembership(Guid teamId, Guid userId)
        {
            TeamId = teamId;
            UserId = userId;
        }
        public void Deactivate()
        {
            if (!IsActive)
                throw new InvalidOperationException("Membership is already inactive.");
            IsActive = false;
            LeftAt = DateTime.UtcNow;
        }
    }
}

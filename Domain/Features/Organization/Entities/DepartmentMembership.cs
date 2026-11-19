using Domain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Features.Organization.Entities
{
    public class DepartmentMembership : BaseEntity
    {
        public Guid DepartmentId { get; private set; }
        public Guid UserId { get; private set; }
        public bool IsActive { get; private set; } = true;
        public DateTime JoinedAt { get; private set; } = DateTime.UtcNow;
        public DateTime? LeftAt { get; private set; }
        public Department Department { get; private set; } = null!;
        private DepartmentMembership() { }
        public DepartmentMembership(Guid departmentId, Guid userId)
        {
            DepartmentId = departmentId;
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

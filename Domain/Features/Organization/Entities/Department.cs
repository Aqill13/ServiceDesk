using Domain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Features.Organization.Entities
{
    public class Department : BaseEntity
    {
        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }
        public bool IsActive { get; private set; } = true;
        private Department() { }
        public Department(string name, string? description)
        {
            Name = name;
            Description = description;
        }
        public void Update(string name, string? description)
        {
            Name = name;
            Description = description;
        }
        public void Deactivate()
        {
            if (!IsActive)
                throw new InvalidOperationException("Department is already deactivated.");
            IsActive = false;
        }
    }
}

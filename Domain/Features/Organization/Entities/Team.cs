using Domain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Features.Organization.Entities
{
    public class Team : BaseEntity
    {
        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }
        public bool IsActive { get; private set; } = true;
        private Team() { }
        public Team(string name, string? description)
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
                throw new InvalidOperationException("Team is already deactivated.");
            IsActive = false;
        }
    }
}

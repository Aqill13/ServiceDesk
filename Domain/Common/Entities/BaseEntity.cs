using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Common.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}

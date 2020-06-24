using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Data.Entities
{
    public class EntityCommonBase
    {
        public Guid Id { get; set; }
        public Guid InsertedBy { get; set; }
        public DateTime InsertdAt { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}

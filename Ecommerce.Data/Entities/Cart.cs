using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Data.Entities
{
    public class Cart: EntityCommonBase
    {
        public Guid? ProductId { get; set; }
        public Product Product { get; set; }
        public int Quality { get; set; }
        public decimal Price { get; set; }
    }
}

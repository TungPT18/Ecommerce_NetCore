using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Data.Entities
{
    public class Order: EntityMasterDataCommonBase
    {
        public DateTime OrderDate { get; set; }
        public Guid UserId { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipEmail { get; set; }
        public string ShipPhoneNumber { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
        public ApplicationUsers ApplicationUsers { get; set; }
    }
}

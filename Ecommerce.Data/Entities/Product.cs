using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Data.Entities
{
    public class Product : EntityCommonBase
    {
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public string SeoAlias { get; set; }
        public ICollection<ProductCategoryMapping> ProductCategoryMappings { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
        public ICollection<Cart> Carts { get; set; }
        public ICollection<ProductTranslation> ProductTranslations { get; set; }

    }
}

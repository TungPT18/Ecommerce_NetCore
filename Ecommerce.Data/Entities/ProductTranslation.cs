using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Data.Entities
{
    public class ProductTranslation : EntityCommonBase
    {
        public Guid? ProductId { get; set; }
        public Product Product { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public Guid? LanguageId { get; set; }
        public Language Language { get; set; }
    }
}

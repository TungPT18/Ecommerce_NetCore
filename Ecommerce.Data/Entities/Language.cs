using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Data.Entities
{
    public class Language: EntityCommonBase
    {
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public ICollection<CategoryTranslation> CategoryTranslations { get; set; }
        public ICollection<ProductTranslation> ProductTranslations { get; set; }
    }
}

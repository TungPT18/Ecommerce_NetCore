using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Data.Entities
{
    public class CategoryTranslation : EntityCommonBase
    {
        public Guid? CategoryId { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public Guid? LanguageId { get; set; }
        public Language Language { get; set; }
        public string SeoAlias { get; set; }
    }
}

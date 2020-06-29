﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Data.Entities
{
    public class Category : EntityMasterDataCommonBase
    {
        public int SortOrder { get; set; }
        public bool IsShowOnHome { get; set; }
        public Guid? ParentId { get; set; }
        public ICollection<ProductCategoryMapping> ProductCategoryMappings { get; set; }
        public ICollection<CategoryTranslation> CategoryTranslations { get; set; }
    }
}

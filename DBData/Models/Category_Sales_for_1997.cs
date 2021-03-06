namespace DBData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Category_Sales_for_1997
    {
        [Key]
        [StringLength(15)]
        public string CategoryName { get; set; }

        public double? CategorySales { get; set; }
    }
}

namespace DBData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products_Above_Average_Price
    {
        [Key]
        [StringLength(40)]
        public string ProductName { get; set; }

        public decimal? UnitPrice { get; set; }
    }
}

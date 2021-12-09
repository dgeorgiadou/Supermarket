namespace DBData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order_DetailsSales_by_CategoryOrder_Details
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string CategoryName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(40)]
        public string ProductName { get; set; }

        public double? ProductSales { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StockOnHand")]
    public partial class StockOnHand
    {
        [Key]
        [Column(Order = 0)]
        public decimal ProductNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WarehouseID { get; set; }

        public int ActualQuantity { get; set; }

        public virtual Product Product { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}

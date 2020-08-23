namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Adjustment")]
    public partial class Adjustment
    {
        public int AdjustmentID { get; set; }

        public DateTime AdjustmentDate { get; set; }

        [Required]
        [StringLength(10)]
        public string ReferenceNo { get; set; }

        public int WarehouseID { get; set; }

        public decimal ProductNo { get; set; }

        public int AdjustmentTypeID { get; set; }

        public decimal Quantity { get; set; }

        public DateTime? ActualDate { get; set; }

        public Guid? UserID { get; set; }

        [StringLength(250)]
        public string Note { get; set; }

        public virtual AdjustmentType AdjustmentType { get; set; }

        public virtual Product Product { get; set; }

        public virtual User User { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}

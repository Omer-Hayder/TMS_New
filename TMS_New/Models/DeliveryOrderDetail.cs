namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeliveryOrderDetail")]
    public partial class DeliveryOrderDetail
    {
        [Key]
        [Column(Order = 0)]
        public decimal PackingID { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ProductNo { get; set; }

        public int OrderedQty { get; set; }

        public int ActualQty { get; set; }

        [StringLength(50)]
        public string Barcode { get; set; }

        public DateTime CreationDate { get; set; }

        public Guid UserID { get; set; }

        public decimal OrderPrice { get; set; }

        public virtual Packing Packing { get; set; }

        public virtual Product Product { get; set; }
    }
}

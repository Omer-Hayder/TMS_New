namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SaleOrderDetail")]
    public partial class SaleOrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal OrderDetailID { get; set; }

        public decimal OrderID { get; set; }

        public decimal ProductNo { get; set; }

        public int RowID { get; set; }

        public int Quantity { get; set; }

        public decimal PriceExclVat { get; set; }

        public decimal PriceInclVat { get; set; }

        public decimal VAT { get; set; }

        public decimal VATAmount { get; set; }

        public decimal TotalExclVat { get; set; }

        public decimal Total { get; set; }

        public DateTime CreationDate { get; set; }

        public Guid UserID { get; set; }

        [StringLength(50)]
        public string Barcode { get; set; }

        public virtual Product Product { get; set; }

        public virtual SaleOrder SaleOrder { get; set; }

        public virtual User User { get; set; }
    }
}

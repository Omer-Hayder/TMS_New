namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PurchaseOrder")]
    public partial class PurchaseOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchaseOrder()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal OrderID { get; set; }

        public long SupplierID { get; set; }

        [Required]
        [StringLength(10)]
        public string OrderNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }

        [Required]
        [StringLength(25)]
        public string ReferenceNo { get; set; }

        public int WarehouseID { get; set; }

        public int PaymentID { get; set; }

        public int OrderStatusID { get; set; }

        public int ProjectID { get; set; }

        [StringLength(250)]
        public string AttachedFile { get; set; }

        public int? TaxID { get; set; }

        public decimal? SubTotal { get; set; }

        public decimal? Discount { get; set; }

        public decimal? TotAfterDis { get; set; }

        public decimal? TotalVAT { get; set; }

        public decimal? Shipping { get; set; }

        public decimal? OrderTotal { get; set; }

        [StringLength(250)]
        public string Note { get; set; }

        public DateTime CreationDate { get; set; }

        public Guid UserID { get; set; }

        public decimal LoyaltyPoints { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual OrderStatu OrderStatu { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual Tax Tax { get; set; }

        public virtual User User { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}

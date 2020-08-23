namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderStatu()
        {
            PurchaseOrders = new HashSet<PurchaseOrder>();
            SaleOrders = new HashSet<SaleOrder>();
        }

        [Key]
        public int OrderStatusID { get; set; }

        [Required]
        [StringLength(50)]
        public string OrderStatusName { get; set; }

        [Required]
        [StringLength(4)]
        public string OrderStatusCode { get; set; }

        [Required]
        [StringLength(8)]
        public string OrderStatusColor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleOrder> SaleOrders { get; set; }
    }
}

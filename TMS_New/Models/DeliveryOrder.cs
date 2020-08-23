namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeliveryOrder")]
    public partial class DeliveryOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DeliveryOrder()
        {
            Packings = new HashSet<Packing>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal DeliveryOrderID { get; set; }

        public long CustomerID { get; set; }

        [Required]
        [StringLength(15)]
        public string DeliveryOrderNo { get; set; }

        [Required]
        [StringLength(25)]
        public string ReferenceNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime DeliveryOrderDate { get; set; }

        public int ProjectID { get; set; }

        [StringLength(250)]
        public string Note { get; set; }

        public DateTime CreationDate { get; set; }

        public Guid UserID { get; set; }

        public int? TransporterID { get; set; }

        public int WarehouseID { get; set; }

        public virtual Warehouse Warehouse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Packing> Packings { get; set; }
    }
}

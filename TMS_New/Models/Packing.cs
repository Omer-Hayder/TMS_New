namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Packing")]
    public partial class Packing
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Packing()
        {
            DeliveryOrderDetails = new HashSet<DeliveryOrderDetail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal PackingID { get; set; }

        public decimal? DeliveryOrderID { get; set; }

        [Required]
        [StringLength(20)]
        public string PackingNumber { get; set; }

        [Required]
        [StringLength(25)]
        public string ReferenceNo { get; set; }

        public DateTime CreationDate { get; set; }

        public Guid UserID { get; set; }

        public int DeliveryStatusID { get; set; }

        public virtual DeliveryOrder DeliveryOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryOrderDetail> DeliveryOrderDetails { get; set; }

        public virtual DeliveryStatu DeliveryStatu { get; set; }
    }
}

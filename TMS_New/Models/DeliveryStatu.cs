namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DeliveryStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DeliveryStatu()
        {
            Packings = new HashSet<Packing>();
        }

        [Key]
        public int DeliveryStatusID { get; set; }

        [Required]
        [StringLength(50)]
        public string DeliveryStatusName { get; set; }

        [StringLength(8)]
        public string DeliveryStatusColor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Packing> Packings { get; set; }
    }
}

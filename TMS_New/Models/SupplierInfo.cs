namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SupplierInfo")]
    public partial class SupplierInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SupplierInfo()
        {
            MaintenanceSpareParts = new HashSet<MaintenanceSparePart>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(250)]
        public string SupplierName { get; set; }

        public string Address { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        public Guid SubID { get; set; }

        public DateTime CreationTime { get; set; }

        public Guid CreatedBy { get; set; }

        public bool? IsDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenanceSparePart> MaintenanceSpareParts { get; set; }
    }
}

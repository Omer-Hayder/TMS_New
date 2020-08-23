namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Maintenance_Vendors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Maintenance_Vendors()
        {
            Maintenance_VendorBranch = new HashSet<Maintenance_VendorBranch>();
            Vendor_Items = new HashSet<Vendor_Items>();
        }

        public long ID { get; set; }

        [Required]
        public string Name { get; set; }

        public int Type { get; set; }

        public bool IsActive { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public Guid? Updatedby { get; set; }

        public DateTime? UpdateTime { get; set; }

        public Guid? SubID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Maintenance_VendorBranch> Maintenance_VendorBranch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vendor_Items> Vendor_Items { get; set; }
    }
}

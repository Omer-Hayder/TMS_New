namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tire
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tire()
        {
            MaintenanceTireAttachements = new HashSet<MaintenanceTireAttachement>();
            TireAssignments = new HashSet<TireAssignment>();
        }

        public Guid ID { get; set; }

        [StringLength(100)]
        public string serialNo { get; set; }

        public bool? isAssigned { get; set; }

        public Guid? brand { get; set; }

        public Guid? manfacturer { get; set; }

        public long? milage { get; set; }

        public Guid type { get; set; }

        public Guid? treadDepth { get; set; }

        public string tread { get; set; }

        public Guid? vendor { get; set; }

        public Guid? warehous { get; set; }

        public Guid? useType { get; set; }

        public int? warrantydays { get; set; }

        public DateTime? PurchaseDate { get; set; }

        [Required]
        public string InvoiceNumber { get; set; }

        public double Price { get; set; }

        public Guid SubID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public bool Isdeleted { get; set; }

        public long? Size { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenanceTireAttachement> MaintenanceTireAttachements { get; set; }

        public virtual MaintenanceTireBrand MaintenanceTireBrand { get; set; }

        public virtual MaintenanceTireManfacturer MaintenanceTireManfacturer { get; set; }

        public virtual MaintenanceTireTreadDepth MaintenanceTireTreadDepth { get; set; }

        public virtual MaintenanceTireType MaintenanceTireType { get; set; }

        public virtual MaintenanceTireUseType MaintenanceTireUseType { get; set; }

        public virtual MaintenanceTireVendor MaintenanceTireVendor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TireAssignment> TireAssignments { get; set; }

        public virtual TireSize TireSize { get; set; }
    }
}

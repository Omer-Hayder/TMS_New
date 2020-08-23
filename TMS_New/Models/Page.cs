namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Page
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Page()
        {
            Service_Pages = new HashSet<Service_Pages>();
            StaffRoles = new HashSet<StaffRole>();
            StaffRoleModulePermissions = new HashSet<StaffRoleModulePermission>();
        }

        public Guid ID { get; set; }

        [Required]
        public string Name { get; set; }

        public Guid ModuleID { get; set; }

        public string UniqueName { get; set; }

        public string Path { get; set; }

        public bool IsGPS { get; set; }

        public bool IsCarRental { get; set; }

        public bool IsMaintenance { get; set; }

        public virtual Module1 Module { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Service_Pages> Service_Pages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffRole> StaffRoles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffRoleModulePermission> StaffRoleModulePermissions { get; set; }
    }
}

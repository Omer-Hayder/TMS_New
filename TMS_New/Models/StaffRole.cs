namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StaffRole
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StaffRole()
        {
            ShiftRules = new HashSet<ShiftRule>();
            Staffs = new HashSet<Staff>();
            StaffRoleDynamicAttributesMaps = new HashSet<StaffRoleDynamicAttributesMap>();
            StaffRoleModulePermissions = new HashSet<StaffRoleModulePermission>();
            TransporterTypeStaffRule_StaffRole = new HashSet<TransporterTypeStaffRule_StaffRole>();
        }

        public Guid ID { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(4000)]
        public string descr { get; set; }

        public Guid subID { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public short category { get; set; }

        public bool? isDefault { get; set; }

        public bool? isModified { get; set; }

        public string Icon { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public bool? isDeleted { get; set; }

        public Guid? PageId { get; set; }

        [StringLength(100)]
        public string NameEn { get; set; }

        [StringLength(100)]
        public string NameAr { get; set; }

        public virtual Page Page { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShiftRule> ShiftRules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff> Staffs { get; set; }

        public virtual StaffRoleCategory StaffRoleCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffRoleDynamicAttributesMap> StaffRoleDynamicAttributesMaps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffRoleModulePermission> StaffRoleModulePermissions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransporterTypeStaffRule_StaffRole> TransporterTypeStaffRule_StaffRole { get; set; }
    }
}

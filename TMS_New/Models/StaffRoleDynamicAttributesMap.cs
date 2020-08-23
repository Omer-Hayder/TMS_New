namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StaffRoleDynamicAttributesMap")]
    public partial class StaffRoleDynamicAttributesMap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StaffRoleDynamicAttributesMap()
        {
            StaffDynamicAttributeMaps = new HashSet<StaffDynamicAttributeMap>();
        }

        public Guid ID { get; set; }

        public Guid? StaffRoleID { get; set; }

        public Guid? SubID { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreationTime { get; set; }

        public int? AttributeCode { get; set; }

        public string AttributeName { get; set; }

        public bool? isDeleted { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public virtual DynamicAttributeType DynamicAttributeType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffDynamicAttributeMap> StaffDynamicAttributeMaps { get; set; }

        public virtual StaffRole StaffRole { get; set; }
    }
}

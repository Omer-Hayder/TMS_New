namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DynamicAttributeType")]
    public partial class DynamicAttributeType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DynamicAttributeType()
        {
            LandmarkTypeMaps = new HashSet<LandmarkTypeMap>();
            StaffRoleDynamicAttributesMaps = new HashSet<StaffRoleDynamicAttributesMap>();
            TransporterTypeMaps = new HashSet<TransporterTypeMap>();
        }

        public Guid ID { get; set; }

        [StringLength(100)]
        public string typeName { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }

        public short? ranking { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LandmarkTypeMap> LandmarkTypeMaps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffRoleDynamicAttributesMap> StaffRoleDynamicAttributesMaps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransporterTypeMap> TransporterTypeMaps { get; set; }
    }
}

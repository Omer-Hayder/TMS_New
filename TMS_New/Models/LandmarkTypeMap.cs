namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LandmarkTypeMap")]
    public partial class LandmarkTypeMap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LandmarkTypeMap()
        {
            LandmarkDynamicAttributeMaps = new HashSet<LandmarkDynamicAttributeMap>();
        }

        public Guid ID { get; set; }

        public Guid LandmarkType { get; set; }

        [Required]
        [StringLength(100)]
        public string attributeName { get; set; }

        public Guid? attributeType { get; set; }

        public int attributeTypeCode { get; set; }

        public Guid subID { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        [StringLength(4000)]
        public string descr { get; set; }

        public bool? isDeleted { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public virtual DynamicAttributeType DynamicAttributeType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LandmarkDynamicAttributeMap> LandmarkDynamicAttributeMaps { get; set; }

        public virtual LandmarkType LandmarkType1 { get; set; }
    }
}

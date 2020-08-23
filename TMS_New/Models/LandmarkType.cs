namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LandmarkType")]
    public partial class LandmarkType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LandmarkType()
        {
            Landmarks = new HashSet<Landmark>();
            LandmarkTypeMaps = new HashSet<LandmarkTypeMap>();
        }

        public Guid ID { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(4000)]
        public string descr { get; set; }

        public bool isActive { get; set; }

        public bool isDefault { get; set; }

        [StringLength(50)]
        public string icon { get; set; }

        public Guid SubID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public bool? isChanged { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public bool? isDeleted { get; set; }

        public bool? isPermenant { get; set; }

        public bool? IsOffice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Landmark> Landmarks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LandmarkTypeMap> LandmarkTypeMaps { get; set; }
    }
}

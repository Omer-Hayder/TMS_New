namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SparePartCategory")]
    public partial class SparePartCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SparePartCategory()
        {
            MaintenanceSpareParts = new HashSet<MaintenanceSparePart>();
        }

        public Guid ID { get; set; }

        public string Name { get; set; }

        public string categoryImage { get; set; }

        public Guid? subID { get; set; }

        public Guid? createdBy { get; set; }

        public DateTime? creationTime { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public bool? isDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenanceSparePart> MaintenanceSpareParts { get; set; }
    }
}

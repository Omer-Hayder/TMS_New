namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TransporterTypeAxle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransporterTypeAxle()
        {
            TireAssignments = new HashSet<TireAssignment>();
        }

        public Guid Id { get; set; }

        public int tiresPerAxle { get; set; }

        public int axleType { get; set; }

        public long? size { get; set; }

        public double? pressure { get; set; }

        public Guid? transporterTypeSkeleton { get; set; }

        public int? rank { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public bool? isDeleted { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreationTime { get; set; }

        public Guid? SubID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TireAssignment> TireAssignments { get; set; }

        public virtual TireSize TireSize { get; set; }

        public virtual TransporterTypeSkeleton TransporterTypeSkeleton1 { get; set; }
    }
}

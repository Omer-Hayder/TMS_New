namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransporterTypeSkeleton")]
    public partial class TransporterTypeSkeleton
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransporterTypeSkeleton()
        {
            TransporterSkeletons = new HashSet<TransporterSkeleton>();
            TransporterTypes = new HashSet<TransporterType>();
            TransporterTypeAxles = new HashSet<TransporterTypeAxle>();
        }

        public Guid Id { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        public int? numberOfAxles { get; set; }

        public Guid SubID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransporterSkeleton> TransporterSkeletons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransporterType> TransporterTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransporterTypeAxle> TransporterTypeAxles { get; set; }
    }
}

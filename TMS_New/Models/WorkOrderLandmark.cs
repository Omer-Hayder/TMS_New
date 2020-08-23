namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WorkOrderLandmark
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkOrderLandmark()
        {
            WorkOrderLandmarkLoadDetails = new HashSet<WorkOrderLandmarkLoadDetail>();
        }

        public Guid Id { get; set; }

        public Guid? WorkOrderID { get; set; }

        public Guid? landmarkId { get; set; }

        public int? sequence { get; set; }

        public DateTime? arrivalTime { get; set; }

        public DateTime? departureTime { get; set; }

        [StringLength(4000)]
        public string note { get; set; }

        public double? distance { get; set; }

        public double? drivingTime { get; set; }

        public double? stoppingTime { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public bool isDeleted { get; set; }

        public double? RestTime { get; set; }

        public virtual Landmark Landmark { get; set; }

        public virtual ProjectWorkOrder ProjectWorkOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrderLandmarkLoadDetail> WorkOrderLandmarkLoadDetails { get; set; }
    }
}

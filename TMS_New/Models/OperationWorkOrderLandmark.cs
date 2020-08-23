namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OperationWorkOrderLandmark
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OperationWorkOrderLandmark()
        {
            LandmarksLoadsDetails = new HashSet<LandmarksLoadsDetail>();
        }

        public long ID { get; set; }

        public Guid WorkOrderId { get; set; }

        public Guid LandmarkFromId { get; set; }

        public bool IsDummy { get; set; }

        public DateTime FromStartDate { get; set; }

        public DateTime FromEndDate { get; set; }

        public double FromWaitingTime { get; set; }

        public double FromRestTime { get; set; }

        public double DrivingTime { get; set; }

        public double Distance { get; set; }

        public Guid? ContainerId { get; set; }

        public Guid LandmarkToId { get; set; }

        public DateTime ToStartDate { get; set; }

        public DateTime ToEndDate { get; set; }

        public double ToWaitingTime { get; set; }

        public double ToRestTime { get; set; }

        public bool IsDeleted { get; set; }

        public Guid CreateBy { get; set; }

        public DateTime CreationDate { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        public virtual aspnet_Users aspnet_Users1 { get; set; }

        public virtual Landmark Landmark { get; set; }

        public virtual Landmark Landmark1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LandmarksLoadsDetail> LandmarksLoadsDetails { get; set; }

        public virtual OperationWorkOrder OperationWorkOrder { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SCO_Plan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SCO_Plan()
        {
            SCO_PlanAttachments = new HashSet<SCO_PlanAttachments>();
            SCO_PlannedTrip = new HashSet<SCO_PlannedTrip>();
        }

        public long Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Code { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        public int PlanTypeId { get; set; }

        public Guid BranchId { get; set; }

        public Guid SubId { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModificationDate { get; set; }

        public DateTime PlanStartDate { get; set; }

        public DateTime PlanEndDate { get; set; }

        public int MaxTripTimeMins { get; set; }

        public TimeSpan? TripStartTime { get; set; }

        public TimeSpan? TripEndTime { get; set; }

        public int WaitingTimeMins { get; set; }

        public DateTime? LastRunDate { get; set; }

        [StringLength(50)]
        public string ActiveDays { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        public virtual aspnet_Users aspnet_Users1 { get; set; }

        public virtual Branch Branch { get; set; }

        public virtual SCO_PlanType SCO_PlanType { get; set; }

        public virtual Subscriber Subscriber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_PlanAttachments> SCO_PlanAttachments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_PlannedTrip> SCO_PlannedTrip { get; set; }
    }
}

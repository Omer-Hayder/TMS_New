namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SCO_PlannedTrip
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SCO_PlannedTrip()
        {
            SCO_DailyTrip = new HashSet<SCO_DailyTrip>();
            SCO_PlannedTripStudents = new HashSet<SCO_PlannedTripStudents>();
        }

        public long Id { get; set; }

        public long PlanId { get; set; }

        public Guid BusId { get; set; }

        public Guid DriverId { get; set; }

        public Guid SupervisorId { get; set; }

        public Guid SourcePOI { get; set; }

        public Guid DestinationPOI { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string RouteString { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }

        public int TripDurationMins { get; set; }

        public double TripMileage { get; set; }

        public int StudentsCount { get; set; }

        public bool IsDeleted { get; set; }

        public int? PlanType { get; set; }

        public DateTime? LastRunDate { get; set; }

        public Guid SubId { get; set; }

        public virtual Landmark Landmark { get; set; }

        public virtual Landmark Landmark1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_DailyTrip> SCO_DailyTrip { get; set; }

        public virtual SCO_Plan SCO_Plan { get; set; }

        public virtual SCO_PlanType SCO_PlanType { get; set; }

        public virtual Staff Staff { get; set; }

        public virtual Staff Staff1 { get; set; }

        public virtual Subscriber Subscriber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_PlannedTripStudents> SCO_PlannedTripStudents { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SCO_DailyTrip
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SCO_DailyTrip()
        {
            SCO_DailyTripStudents = new HashSet<SCO_DailyTripStudents>();
            SCO_Notifications = new HashSet<SCO_Notifications>();
        }

        public long Id { get; set; }

        public long PlannedTripId { get; set; }

        public DateTime PlannedTripStartDateTime { get; set; }

        public Guid BusId { get; set; }

        public Guid DriverId { get; set; }

        public Guid SupervisorId { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string ActualRouteString { get; set; }

        public TimeSpan ActualStartTime { get; set; }

        public TimeSpan ActualEndTime { get; set; }

        public int ActualTripDurationMins { get; set; }

        public double ActualTripMileage { get; set; }

        public int ActualStudentsCount { get; set; }

        public int TripStatusId { get; set; }

        public bool IsDeleted { get; set; }

        public Guid SubId { get; set; }

        public virtual SCO_PlannedTrip SCO_PlannedTrip { get; set; }

        public virtual SCO_TripStatus SCO_TripStatus { get; set; }

        public virtual Staff Staff { get; set; }

        public virtual Staff Staff1 { get; set; }

        public virtual Subscriber Subscriber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_DailyTripStudents> SCO_DailyTripStudents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_Notifications> SCO_Notifications { get; set; }
    }
}

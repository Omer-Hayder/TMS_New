namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SCO_DailyTripStudents
    {
        public long Id { get; set; }

        public long DailyTripId { get; set; }

        public TimeSpan? ActualArrivedTime { get; set; }

        public int ActualStudentOrder { get; set; }

        public int StudentStatusId { get; set; }

        public long StudentId { get; set; }

        public TimeSpan? PickupTime { get; set; }

        public TimeSpan? DropOffTime { get; set; }

        public DateTime? ModificationDate { get; set; }

        public virtual SCO_DailyTrip SCO_DailyTrip { get; set; }

        public virtual SCO_StudentTripStatus SCO_StudentTripStatus { get; set; }

        public virtual SCO_Students SCO_Students { get; set; }
    }
}

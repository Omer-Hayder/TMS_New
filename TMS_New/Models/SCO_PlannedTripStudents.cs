namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SCO_PlannedTripStudents
    {
        public long Id { get; set; }

        public long PlannedTripId { get; set; }

        public long StudentId { get; set; }

        public TimeSpan PlannedArrivalTime { get; set; }

        public int PlannedStudentOrder { get; set; }

        public bool? IsDeleted { get; set; }

        public virtual SCO_PlannedTrip SCO_PlannedTrip { get; set; }

        public virtual SCO_Students SCO_Students { get; set; }
    }
}

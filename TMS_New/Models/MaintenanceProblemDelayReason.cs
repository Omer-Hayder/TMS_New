namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaintenanceProblemDelayReason")]
    public partial class MaintenanceProblemDelayReason
    {
        public Guid Id { get; set; }

        public Guid ProblemId { get; set; }

        public long DelayReasonId { get; set; }

        public virtual MaintenanceDelayReason MaintenanceDelayReason { get; set; }

        public virtual Problem Problem { get; set; }
    }
}

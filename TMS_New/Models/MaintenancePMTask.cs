namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MaintenancePMTask
    {
        public Guid ID { get; set; }

        public string Description { get; set; }

        public Guid? TaskType { get; set; }

        public Guid? PMId { get; set; }

        public int? LabourCount { get; set; }

        public int? Duration { get; set; }

        public int? DurationType { get; set; }

        public virtual MaintenancePM MaintenancePM { get; set; }

        public virtual ProblemType ProblemType { get; set; }
    }
}

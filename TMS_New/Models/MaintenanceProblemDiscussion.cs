namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaintenanceProblemDiscussion")]
    public partial class MaintenanceProblemDiscussion
    {
        public Guid ID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime? CreationTime { get; set; }

        public bool? isRead { get; set; }

        public string Text { get; set; }

        public Guid? problemId { get; set; }

        public bool? IsMaintenanceTeam { get; set; }

        public virtual Problem Problem { get; set; }

        public virtual Staff Staff { get; set; }
    }
}

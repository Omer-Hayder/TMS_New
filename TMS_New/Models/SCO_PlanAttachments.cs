namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SCO_PlanAttachments
    {
        public long Id { get; set; }

        public long PlanId { get; set; }

        [Required]
        public string AttachName { get; set; }

        [Required]
        public string AttachPath { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationDate { get; set; }

        public virtual SCO_Plan SCO_Plan { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SCO_StudentAttachments
    {
        public long Id { get; set; }

        public long StudentId { get; set; }

        [Required]
        public string AttachName { get; set; }

        [Required]
        public string AttachPath { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationDate { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        public virtual SCO_Students SCO_Students { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RequestForRepairAttachement
    {
        public Guid ID { get; set; }

        public Guid requestForRepairId { get; set; }

        [Required]
        public string File { get; set; }

        public string FileName { get; set; }

        public virtual RequestForRepair RequestForRepair { get; set; }
    }
}

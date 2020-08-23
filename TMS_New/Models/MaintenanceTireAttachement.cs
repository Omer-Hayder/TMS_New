namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MaintenanceTireAttachement
    {
        public Guid ID { get; set; }

        public string File { get; set; }

        public string FileName { get; set; }

        public Guid? Tire { get; set; }

        public virtual Tire Tire1 { get; set; }
    }
}

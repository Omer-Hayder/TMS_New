namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaintenancePMTransporter")]
    public partial class MaintenancePMTransporter
    {
        public Guid Id { get; set; }

        public Guid Transporter { get; set; }

        public Guid PM { get; set; }

        public virtual MaintenancePM MaintenancePM { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaintenanceWorkorderStatusLog")]
    public partial class MaintenanceWorkorderStatusLog
    {
        public Guid Id { get; set; }

        public int? NewStatus { get; set; }

        public int? OldStatus { get; set; }

        public DateTime? ChangeDate { get; set; }

        public Guid? ChangedBy { get; set; }

        public Guid? WOId { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        public virtual MaintenanceWorkOrder MaintenanceWorkOrder { get; set; }
    }
}

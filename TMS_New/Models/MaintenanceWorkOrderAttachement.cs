namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaintenanceWorkOrderAttachement")]
    public partial class MaintenanceWorkOrderAttachement
    {
        public int ID { get; set; }

        public string File { get; set; }

        public string FileName { get; set; }

        public Guid? maintenanceWorkOrder { get; set; }

        public Guid? UserId { get; set; }

        public DateTime? DateIn { get; set; }

        public bool? Isdeleted { get; set; }

        public Guid? Modifiedby { get; set; }

        public DateTime? ModificationDate { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        public virtual MaintenanceWorkOrder MaintenanceWorkOrder1 { get; set; }
    }
}

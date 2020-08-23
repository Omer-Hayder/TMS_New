namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MaintenancePMSetupTransporter_Log
    {
        public Guid Id { get; set; }

        public Guid? PMSetupId { get; set; }

        public Guid? TransporterId { get; set; }

        public double? CurrentPMMilage { get; set; }

        public DateTime? CurrentPMDate { get; set; }

        public double? NextPMMilage { get; set; }

        public DateTime? NextPMDate { get; set; }

        public DateTime? CreationTime { get; set; }

        public Guid? CreatedBy { get; set; }

        public double? NextPMHours { get; set; }

        public double? CurrentPMHours { get; set; }

        public virtual MaintenancePMSetupTransporter MaintenancePMSetupTransporter { get; set; }
    }
}

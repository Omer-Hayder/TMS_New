namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transporter_ContractData
    {
        public long ID { get; set; }

        public Guid TransporterId { get; set; }

        [StringLength(100)]
        public string ContractNumber { get; set; }

        public int? MaintenanceWorkOrderVendorId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(150)]
        public string ClassificationOfContract { get; set; }

        public virtual MaintenanceWorkOrderVendor MaintenanceWorkOrderVendor { get; set; }
    }
}

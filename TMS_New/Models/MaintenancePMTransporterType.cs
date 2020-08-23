namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaintenancePMTransporterType")]
    public partial class MaintenancePMTransporterType
    {
        public Guid Id { get; set; }

        public Guid TransporterType { get; set; }

        public Guid PM { get; set; }

        public virtual MaintenancePM MaintenancePM { get; set; }

        public virtual TransporterType TransporterType1 { get; set; }
    }
}

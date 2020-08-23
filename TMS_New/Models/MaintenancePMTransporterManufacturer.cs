namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaintenancePMTransporterManufacturer")]
    public partial class MaintenancePMTransporterManufacturer
    {
        public Guid ID { get; set; }

        public Guid TransporterManufacturer { get; set; }

        public Guid PM { get; set; }

        public virtual MaintenancePM MaintenancePM { get; set; }

        public virtual TransporterManufacturer TransporterManufacturer1 { get; set; }
    }
}

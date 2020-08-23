namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaintenancePMTransporterBrand")]
    public partial class MaintenancePMTransporterBrand
    {
        public Guid ID { get; set; }

        public Guid TransporterBrand { get; set; }

        public Guid PM { get; set; }

        public virtual MaintenancePM MaintenancePM { get; set; }

        public virtual TransporterBrand TransporterBrand1 { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransporterFuelData")]
    public partial class TransporterFuelData
    {
        public long ID { get; set; }

        public double Data { get; set; }

        public double Value { get; set; }

        public Guid TransporterID { get; set; }
    }
}

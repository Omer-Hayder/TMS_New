namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DailyMileageLog")]
    public partial class DailyMileageLog
    {
        public long ID { get; set; }

        public Guid TransporterID { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateTimeUTC { get; set; }

        public double Mileage { get; set; }

        public Guid SubId { get; set; }

        public DateTime? CurrentDateTime { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DailyMileageLogForTrace")]
    public partial class DailyMileageLogForTrace
    {
        public long ID { get; set; }

        public Guid TransporterID { get; set; }

        public DateTime? DateTimeBefore { get; set; }

        public DateTime DateTimeAfter { get; set; }

        public double? MileageBefore { get; set; }

        public double MileageAfter { get; set; }

        public Guid SubId { get; set; }
    }
}

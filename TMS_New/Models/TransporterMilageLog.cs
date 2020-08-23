namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransporterMilageLog")]
    public partial class TransporterMilageLog
    {
        public long Id { get; set; }

        public Guid? TransporterId { get; set; }

        public DateTime? DateIn { get; set; }

        public long? NewMileage { get; set; }

        public Guid? UserId { get; set; }

        public Guid? SubId { get; set; }
    }
}

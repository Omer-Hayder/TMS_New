namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GeofensesLandmarksLog")]
    public partial class GeofensesLandmarksLog
    {
        public long ID { get; set; }

        public Guid SubID { get; set; }

        public Guid TransporterID { get; set; }

        public Guid GeofenseID { get; set; }

        public DateTime ViolationDate { get; set; }

        public double latitude { get; set; }

        public double longitude { get; set; }

        public bool Type { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_WorkOrderPlannedRout
    {
        public long ID { get; set; }

        public long WorkOrderID { get; set; }

        public DateTime? CreatedTime { get; set; }

        public Guid CreatedBy { get; set; }

        public bool? IsDeleted { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        [Column(TypeName = "text")]
        public string RouteJSON { get; set; }

        public string RouteLatLngString { get; set; }

        public long? DrivingTime { get; set; }

        public decimal? Distance { get; set; }
    }
}

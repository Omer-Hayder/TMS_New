namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_VehicleLog
    {
        public long ID { get; set; }

        public Guid VehicleID { get; set; }

        public Guid? DriverID { get; set; }

        public long? WorkOrderID { get; set; }

        public int StatusID { get; set; }

        public int ActionLogTypeID { get; set; }

        public DateTime? CreateTime { get; set; }

        public Guid? CreatedBy { get; set; }
    }
}

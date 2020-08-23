namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_RestrictedZoneVehicleType
    {
        public long ID { get; set; }

        public Guid VehicleTypeID { get; set; }

        public long ZoneID { get; set; }

        public virtual NWC_Zone NWC_Zone { get; set; }

        public virtual TransporterType TransporterType { get; set; }
    }
}

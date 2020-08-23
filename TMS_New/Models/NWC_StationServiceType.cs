namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_StationServiceType
    {
        public long ID { get; set; }

        public Guid StationID { get; set; }

        public int ServiceTypeID { get; set; }

        public virtual Landmark Landmark { get; set; }

        public virtual NWC_ServiceType NWC_ServiceType { get; set; }
    }
}

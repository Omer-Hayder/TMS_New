namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_VehicleAccessory
    {
        public long ID { get; set; }

        public Guid VehicleID { get; set; }

        public int AccessoryID { get; set; }

        public virtual NWC_Accessory NWC_Accessory { get; set; }
    }
}

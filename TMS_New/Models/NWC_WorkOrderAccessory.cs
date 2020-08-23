namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_WorkOrderAccessory
    {
        public long ID { get; set; }

        public long WorkOrderID { get; set; }

        public int AccessoryID { get; set; }

        public virtual NWC_Accessory NWC_Accessory { get; set; }

        public virtual NWC_EventWorkOrder NWC_EventWorkOrder { get; set; }
    }
}

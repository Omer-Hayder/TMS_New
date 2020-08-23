namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_DefaultTankerSize
    {
        public long ID { get; set; }

        public int TankerSize { get; set; }

        public decimal TankerPrince { get; set; }

        public DateTime TankerDeleviryTime { get; set; }
    }
}

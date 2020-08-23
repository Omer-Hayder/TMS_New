namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_EventType
    {
        public int ID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }
    }
}

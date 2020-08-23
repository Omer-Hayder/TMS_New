namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BatteryAssignment")]
    public partial class BatteryAssignment
    {
        public Guid ID { get; set; }

        public Guid? battery { get; set; }

        public Guid? transporter { get; set; }

        public virtual Battery Battery1 { get; set; }
    }
}

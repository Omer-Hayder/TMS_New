namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FuelLog")]
    public partial class FuelLog
    {
        public int id { get; set; }

        public Guid? sub_id { get; set; }

        public Guid? created_by { get; set; }

        public Guid? transporter_id { get; set; }

        public double? fuel_value { get; set; }

        public DateTime? fuel_date_time { get; set; }

        public double? fuel_cost { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        public virtual Subscriber Subscriber { get; set; }
    }
}

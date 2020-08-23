namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SubscriberLog
    {
        public Guid ID { get; set; }

        public DateTime date { get; set; }

        public Guid subID { get; set; }

        public int fleetSize { get; set; }

        public Guid offerID { get; set; }

        [Required]
        [StringLength(10)]
        public string status { get; set; }

        [Column(TypeName = "money")]
        public decimal monthValue { get; set; }

        public virtual Offer Offer { get; set; }

        public virtual Subscriber Subscriber { get; set; }
    }
}

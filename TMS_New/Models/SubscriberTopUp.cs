namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SubscriberTopUp
    {
        public Guid ID { get; set; }

        public Guid SubID { get; set; }

        public DateTime CreationTime { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "money")]
        public decimal? CurrentBalance { get; set; }

        [Column(TypeName = "money")]
        public decimal? CreditAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? DebitAmount { get; set; }

        [StringLength(4000)]
        public string description { get; set; }

        public virtual Subscriber Subscriber { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SubscriptionActivityLog")]
    public partial class SubscriptionActivityLog
    {
        public Guid ID { get; set; }

        public Guid? SubscriberId { get; set; }

        public byte? SubscriberState { get; set; }

        public string Reason { get; set; }

        public DateTime? CreationDate { get; set; }

        public Guid? CreatedBy { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        public virtual Subscriber Subscriber { get; set; }
    }
}

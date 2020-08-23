namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ReportSubscriptionUser
    {
        public long ID { get; set; }

        public Guid SubscriptionID { get; set; }

        public Guid UserID { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public virtual aspnet_Membership aspnet_Membership { get; set; }

        public virtual ReportSubscription ReportSubscription { get; set; }
    }
}

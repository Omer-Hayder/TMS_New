namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NotificationsConfiguration_NotificationsRelatedTo
    {
        public long ID { get; set; }

        public long NotificationId { get; set; }

        public long RelatedTo { get; set; }

        public int? Notify_Before_Days { get; set; }

        public virtual NotificationConfiguration NotificationConfiguration { get; set; }

        public virtual NotificationsRelatedTo NotificationsRelatedTo { get; set; }
    }
}

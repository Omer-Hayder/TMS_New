namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SCO_Notifications
    {
        public long Id { get; set; }

        [Required]
        public string NotificationText { get; set; }

        public DateTime CreationDate { get; set; }

        public int NotificationTypeId { get; set; }

        public Guid NotifiedId { get; set; }

        public long TripId { get; set; }

        public long StudentId { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        public virtual SCO_DailyTrip SCO_DailyTrip { get; set; }

        public virtual SCO_Students SCO_Students { get; set; }
    }
}

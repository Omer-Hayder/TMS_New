namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomNotificationLog")]
    public partial class CustomNotificationLog
    {
        public long ID { get; set; }

        public Guid? TransporterId { get; set; }

        public Guid? StaffId { get; set; }

        public long NotificationRelatedTo { get; set; }

        public DateTime FieldDate { get; set; }

        public DateTime LastActionDate { get; set; }

        public virtual Staff Staff { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NotificationInbox_EmailLog
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NotificationInboxId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid StaffId { get; set; }

        public bool IsSend { get; set; }

        public DateTime? SendDate { get; set; }

        public int NumTrials { get; set; }

        public string FailureMessage { get; set; }

        [Required]
        public string NotificationText { get; set; }

        public DateTime DateCreated { get; set; }

        public string EmailSubject { get; set; }

        public int? FilterDate { get; set; }

        public virtual NotificationInbox NotificationInbox { get; set; }

        public virtual Staff Staff { get; set; }
    }
}

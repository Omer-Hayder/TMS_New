namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NotificationsRelatedTo")]
    public partial class NotificationsRelatedTo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NotificationsRelatedTo()
        {
            NotificationInboxes = new HashSet<NotificationInbox>();
            NotificationsConfiguration_NotificationsRelatedTo = new HashSet<NotificationsConfiguration_NotificationsRelatedTo>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public string Name { get; set; }

        public long? NotificationForId { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public bool? isDeleted { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public string EmailMessage { get; set; }

        public string EmailSubject { get; set; }

        public string InSystemMessage { get; set; }

        public string SMSMessage { get; set; }

        [StringLength(50)]
        public string SMSSender { get; set; }

        public bool? has_Notify_Before_Days { get; set; }

        public bool? isRealTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationInbox> NotificationInboxes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationsConfiguration_NotificationsRelatedTo> NotificationsConfiguration_NotificationsRelatedTo { get; set; }

        public virtual NotificationsFor NotificationsFor { get; set; }
    }
}

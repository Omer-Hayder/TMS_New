namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NotificationInbox")]
    public partial class NotificationInbox
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NotificationInbox()
        {
            NotificationInbox_EmailLog = new HashSet<NotificationInbox_EmailLog>();
            NotificationInbox_SMSLog = new HashSet<NotificationInbox_SMSLog>();
            NotificationInbox_InSystemLog = new HashSet<NotificationInbox_InSystemLog>();
        }

        public long ID { get; set; }

        public string Desc { get; set; }

        public long? NotificationConfiguration { get; set; }

        public Guid SubID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public bool? isDeleted { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public string EmailSubject { get; set; }

        [StringLength(50)]
        public string SMSSender { get; set; }

        public long? RelatedToID { get; set; }

        public Guid? DriverId { get; set; }

        public double? Lat { get; set; }

        public double? Lon { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        public Guid? TransporterId { get; set; }

        public string NotificationText { get; set; }

        public bool? IsReceived_Mobile { get; set; }

        public bool? IsSended_Mobile { get; set; }

        public virtual NotificationConfiguration NotificationConfiguration1 { get; set; }

        public virtual NotificationsRelatedTo NotificationsRelatedTo { get; set; }

        public virtual Staff Staff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationInbox_EmailLog> NotificationInbox_EmailLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationInbox_SMSLog> NotificationInbox_SMSLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationInbox_InSystemLog> NotificationInbox_InSystemLog { get; set; }
    }
}

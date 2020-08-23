namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NotificationConfiguration")]
    public partial class NotificationConfiguration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NotificationConfiguration()
        {
            NotificationConfiguration_Customer = new HashSet<NotificationConfiguration_Customer>();
            NotificationConfiguration_Groups = new HashSet<NotificationConfiguration_Groups>();
            NotificationConfiguration_LandMarks = new HashSet<NotificationConfiguration_LandMarks>();
            NotificationConfiguration_Staff = new HashSet<NotificationConfiguration_Staff>();
            NotificationConfiguration_SubBranch = new HashSet<NotificationConfiguration_SubBranch>();
            NotificationConfiguration_TransporterTypes = new HashSet<NotificationConfiguration_TransporterTypes>();
            NotificationInboxes = new HashSet<NotificationInbox>();
            NotificationsConfiguration_NotificationsRelatedTo = new HashSet<NotificationsConfiguration_NotificationsRelatedTo>();
        }

        public long ID { get; set; }

        public string Name { get; set; }

        public long? NotificationForId { get; set; }

        public int? NotificationTypeId { get; set; }

        public Guid SubID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public bool? isDeleted { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public bool? isMail { get; set; }

        public bool? isSMS { get; set; }

        public bool? isSystem { get; set; }

        [StringLength(50)]
        public string Language { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationConfiguration_Customer> NotificationConfiguration_Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationConfiguration_Groups> NotificationConfiguration_Groups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationConfiguration_LandMarks> NotificationConfiguration_LandMarks { get; set; }

        public virtual NotificationsFor NotificationsFor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationConfiguration_Staff> NotificationConfiguration_Staff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationConfiguration_SubBranch> NotificationConfiguration_SubBranch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationConfiguration_TransporterTypes> NotificationConfiguration_TransporterTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationInbox> NotificationInboxes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationsConfiguration_NotificationsRelatedTo> NotificationsConfiguration_NotificationsRelatedTo { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReportSubscription")]
    public partial class ReportSubscription
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReportSubscription()
        {
            ReportSubscriptionUsers = new HashSet<ReportSubscriptionUser>();
        }

        public Guid ID { get; set; }

        public Guid RSID { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public int ScheduleType { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportSubscriptionUser> ReportSubscriptionUsers { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Report")]
    public partial class Report
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Report()
        {
            SubscriberDisabledReports = new HashSet<SubscriberDisabledReport>();
        }

        public Guid Id { get; set; }

        [StringLength(128)]
        public string UniqueName { get; set; }

        public string ARName { get; set; }

        public string ENName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubscriberDisabledReport> SubscriberDisabledReports { get; set; }
    }
}

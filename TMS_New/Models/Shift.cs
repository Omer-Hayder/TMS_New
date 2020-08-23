namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shift")]
    public partial class Shift
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shift()
        {
            ShiftRules = new HashSet<ShiftRule>();
            StaffShifts = new HashSet<StaffShift>();
            TransporterShifts = new HashSet<TransporterShift>();
        }

        public Guid Id { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        public string IntervalRule { get; set; }

        public string RepeatRule { get; set; }

        public Guid? SubId { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreationTime { get; set; }

        public bool? linkedToCompanyHours { get; set; }

        public TimeSpan? FromTime { get; set; }

        public int? IntervalBased { get; set; }

        public TimeSpan? ToTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShiftRule> ShiftRules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffShift> StaffShifts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransporterShift> TransporterShifts { get; set; }
    }
}

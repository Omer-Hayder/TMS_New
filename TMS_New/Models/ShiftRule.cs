namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShiftRule")]
    public partial class ShiftRule
    {
        public Guid Id { get; set; }

        public Guid? Shift { get; set; }

        public int? appliedFor { get; set; }

        public Guid? StaffRole { get; set; }

        public Guid? TransporterType { get; set; }

        public int? index { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreationTime { get; set; }

        public Guid? SubId { get; set; }

        public virtual Shift Shift1 { get; set; }

        public virtual StaffRole StaffRole1 { get; set; }

        public virtual TransporterType TransporterType1 { get; set; }
    }
}

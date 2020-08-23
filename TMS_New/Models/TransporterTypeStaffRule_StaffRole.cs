namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TransporterTypeStaffRule_StaffRole
    {
        public Guid Id { get; set; }

        public Guid? transporterTypeStaffRule { get; set; }

        public Guid? staffRole { get; set; }

        public int? staffNumber { get; set; }

        public virtual StaffRole StaffRole1 { get; set; }

        public virtual TransporterTypeStaffRule TransporterTypeStaffRule1 { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StaffShift")]
    public partial class StaffShift
    {
        public Guid Id { get; set; }

        public Guid? Shift { get; set; }

        public Guid? Staff { get; set; }

        public Guid SubId { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public virtual Shift Shift1 { get; set; }

        public virtual Staff Staff1 { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransporterStaffRule")]
    public partial class TransporterStaffRule
    {
        public Guid Id { get; set; }

        public Guid? staffRule { get; set; }

        public Guid? transporter { get; set; }

        public Guid subID { get; set; }

        public Guid createdBy { get; set; }

        public DateTime creationTime { get; set; }

        public virtual TransporterTypeStaffRule TransporterTypeStaffRule { get; set; }
    }
}

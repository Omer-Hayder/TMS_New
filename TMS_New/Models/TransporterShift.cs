namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransporterShift")]
    public partial class TransporterShift
    {
        public Guid Id { get; set; }

        public Guid? Shift { get; set; }

        public Guid? Transporter { get; set; }

        public Guid SubId { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public virtual Shift Shift1 { get; set; }
    }
}

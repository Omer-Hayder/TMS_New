namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProblemStatusLog")]
    public partial class ProblemStatusLog
    {
        public Guid Id { get; set; }

        public int? NewStatus { get; set; }

        public int? OldStatus { get; set; }

        public DateTime? ChangeDate { get; set; }

        public Guid? ChangedBy { get; set; }

        public Guid? ProblemId { get; set; }

        public virtual Problem Problem { get; set; }
    }
}

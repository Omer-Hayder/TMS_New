namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SCO_AbsencePlanStudent
    {
        public long Id { get; set; }

        public long StudentId { get; set; }

        public long AbsencePlanId { get; set; }

        public bool? Isdeleted { get; set; }

        public virtual SCO_AbsencePlan SCO_AbsencePlan { get; set; }

        public virtual SCO_Students SCO_Students { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SCO_StudentGuardianRelation
    {
        public long Id { get; set; }

        public int RelativeRelationId { get; set; }

        public long StudentId { get; set; }

        public long GuardiansId { get; set; }

        public bool IsMainContact { get; set; }

        public bool IsDeleted { get; set; }

        public virtual SCO_Guardians SCO_Guardians { get; set; }

        public virtual SCO_RelativeRelations SCO_RelativeRelations { get; set; }

        public virtual SCO_Students SCO_Students { get; set; }
    }
}

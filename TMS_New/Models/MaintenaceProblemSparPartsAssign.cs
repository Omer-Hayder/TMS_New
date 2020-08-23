namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaintenaceProblemSparPartsAssign")]
    public partial class MaintenaceProblemSparPartsAssign
    {
        public Guid ID { get; set; }

        public Guid? sparePartId { get; set; }

        public Guid? problemId { get; set; }

        public DateTime? CreationTime { get; set; }

        public DateTime? deactivationDate { get; set; }

        public bool? IsActive { get; set; }

        public Guid CreatedBy { get; set; }

        public int? Count { get; set; }

        public decimal? UnitPrice { get; set; }

        public virtual MaintenanceSparePart MaintenanceSparePart { get; set; }

        public virtual Problem Problem { get; set; }
    }
}

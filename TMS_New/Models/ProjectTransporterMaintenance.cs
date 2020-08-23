namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProjectTransporterMaintenance")]
    public partial class ProjectTransporterMaintenance
    {
        public Guid Id { get; set; }

        public Guid? ProjectId { get; set; }

        public Guid? TransporterId { get; set; }

        public Guid? WorkorderId { get; set; }

        public Guid SubId { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public bool? isDeleted { get; set; }

        public virtual WorkOrder WorkOrder { get; set; }
    }
}

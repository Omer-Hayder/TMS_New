namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransporterSkeleton")]
    public partial class TransporterSkeleton
    {
        public Guid Id { get; set; }

        public Guid transporter { get; set; }

        public Guid skeletonId { get; set; }

        public virtual TransporterTypeSkeleton TransporterTypeSkeleton { get; set; }
    }
}

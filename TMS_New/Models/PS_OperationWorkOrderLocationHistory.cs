namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PS_OperationWorkOrderLocationHistory
    {
        public long Id { get; set; }

        public long WorkOrderId { get; set; }

        public Guid? TransporterId { get; set; }

        public Guid? LandmarkId { get; set; }

        public DateTime? StartDateTime { get; set; }

        public DateTime? EndDateTime { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StartLatitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StartLongitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EndLatitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EndLongitude { get; set; }

        public long? ActionId { get; set; }

        public virtual Landmark Landmark { get; set; }

        public virtual PS_OperationWorkOrder PS_OperationWorkOrder { get; set; }
    }
}

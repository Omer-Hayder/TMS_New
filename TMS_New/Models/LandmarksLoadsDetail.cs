namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LandmarksLoadsDetail
    {
        public long Id { get; set; }

        public long WorkOrderLandmarkId { get; set; }

        public long WorkOrderLoadId { get; set; }

        public double? Loaded { get; set; }

        public double? Load { get; set; }

        public double? Unload { get; set; }

        public bool IsDeleted { get; set; }

        public Guid CreateBy { get; set; }

        public DateTime CreationDate { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        public virtual aspnet_Users aspnet_Users1 { get; set; }

        public virtual OperationWorkOrderLandmark OperationWorkOrderLandmark { get; set; }

        public virtual WorkOrdersLoad WorkOrdersLoad { get; set; }
    }
}

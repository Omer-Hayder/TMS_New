namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WorkOrderLandmarkLoadDetail
    {
        public Guid ID { get; set; }

        public Guid? WorkOrderLandMarkID { get; set; }

        public Guid? ProjectLoadID { get; set; }

        public double LoadedAmount { get; set; }

        public double LoadAmount { get; set; }

        public double UnloadAmount { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public bool isDeleted { get; set; }

        public virtual OperationProjectLoad OperationProjectLoad { get; set; }

        public virtual WorkOrderLandmark WorkOrderLandmark { get; set; }
    }
}

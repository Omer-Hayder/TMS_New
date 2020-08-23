namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WorkOrderCost
    {
        public long ID { get; set; }

        public long CostId { get; set; }

        public double Value { get; set; }

        public Guid WorkOrderId { get; set; }

        public bool IsDeleted { get; set; }

        public Guid CreateBy { get; set; }

        public DateTime CreationDate { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        public virtual aspnet_Users aspnet_Users1 { get; set; }

        public virtual OperationCost OperationCost { get; set; }

        public virtual OperationWorkOrder OperationWorkOrder { get; set; }
    }
}

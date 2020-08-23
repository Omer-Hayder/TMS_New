namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PS_OperationWorkOrder_Resources
    {
        public long Id { get; set; }

        public long? WorkOrderId { get; set; }

        public Guid? StaffId { get; set; }

        public long ResourceTypeId { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreationTime { get; set; }

        public virtual PS_OperationWorkOrder PS_OperationWorkOrder { get; set; }

        public virtual PS_OperationWorkOrder_ResourceType PS_OperationWorkOrder_ResourceType { get; set; }

        public virtual Staff Staff { get; set; }
    }
}

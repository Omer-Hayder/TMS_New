namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PS_OperationWorkOrder_StatusLog
    {
        public long Id { get; set; }

        public long? WoId { get; set; }

        public int? StatusId { get; set; }

        [StringLength(50)]
        public string StatusName { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreationTime { get; set; }

        public string Comment { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        public virtual PS_OperationWorkOrder PS_OperationWorkOrder { get; set; }

        public virtual PS_OperationWorkOrder_Status PS_OperationWorkOrder_Status { get; set; }
    }
}

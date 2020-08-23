namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PS_OperationWorkOrderCodeSerial
    {
        public long Id { get; set; }

        public Guid BranchId { get; set; }

        [Required]
        [StringLength(10)]
        public string BranchPrefix { get; set; }

        public int LastSequence { get; set; }

        public long? WorkOrderId { get; set; }

        public virtual Branch Branch { get; set; }

        public virtual PS_OperationWorkOrder PS_OperationWorkOrder { get; set; }
    }
}

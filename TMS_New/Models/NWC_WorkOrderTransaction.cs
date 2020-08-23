namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_WorkOrderTransaction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public DateTime TransactionDate { get; set; }

        public Guid? CreatedBy { get; set; }

        public bool? IsDeleted { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? ModifiedAt { get; set; }

        public virtual NWC_EventWorkOrder NWC_EventWorkOrder { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_WorkOrderComplaint
    {
        public long ID { get; set; }

        public long WorkOrderID { get; set; }

        [Required]
        [StringLength(10)]
        public string Number { get; set; }

        public Guid? RaisedBy { get; set; }

        public DateTime? RaisedTime { get; set; }

        public int CategoryID { get; set; }

        public int PriorityID { get; set; }

        public int StatusID { get; set; }

        public string Description { get; set; }

        public bool? IsDeleted { get; set; }

        public virtual NWC_ComplaintCategory NWC_ComplaintCategory { get; set; }

        public virtual NWC_ComplaintPriority NWC_ComplaintPriority { get; set; }

        public virtual NWC_ComplaintStatus NWC_ComplaintStatus { get; set; }

        public virtual NWC_StateWorkOrder NWC_StateWorkOrder { get; set; }

        public virtual Staff Staff { get; set; }
    }
}

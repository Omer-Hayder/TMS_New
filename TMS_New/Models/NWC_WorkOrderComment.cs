namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_WorkOrderComment
    {
        public long ID { get; set; }

        public long WorkOrderID { get; set; }

        public string Comment { get; set; }

        public DateTime? CreatedTime { get; set; }

        public Guid? CreatedBy { get; set; }

        public bool? IsDeleted { get; set; }

        public virtual NWC_StateWorkOrder NWC_StateWorkOrder { get; set; }

        public virtual Staff Staff { get; set; }
    }
}

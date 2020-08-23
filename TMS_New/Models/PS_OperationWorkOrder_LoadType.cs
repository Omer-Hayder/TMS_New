namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PS_OperationWorkOrder_LoadType
    {
        public long id { get; set; }

        public long? OperationWorkOrderId { get; set; }

        public long? LoadTypeId { get; set; }

        public virtual PS_LoadType PS_LoadType { get; set; }

        public virtual PS_OperationWorkOrder PS_OperationWorkOrder { get; set; }
    }
}

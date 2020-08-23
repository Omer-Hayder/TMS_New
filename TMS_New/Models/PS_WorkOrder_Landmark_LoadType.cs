namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PS_WorkOrder_Landmark_LoadType
    {
        public long Id { get; set; }

        public long? WO_LandmarkId { get; set; }

        public long? LoadTypeId { get; set; }

        public decimal? LoadTypeValuePickup { get; set; }

        public decimal? LoadTypeValueDrop { get; set; }

        public virtual PS_LoadType PS_LoadType { get; set; }

        public virtual PS_OperationWorkOrder_Landmark PS_OperationWorkOrder_Landmark { get; set; }
    }
}

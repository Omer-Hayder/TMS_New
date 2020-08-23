namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_SoqyaSchedules
    {
        public long ID { get; set; }

        public long CustomerAccountId { get; set; }

        public DateTime ScheduleDate { get; set; }

        public TimeSpan? TimeSlotFrom { get; set; }

        public TimeSpan? TimeSlotTo { get; set; }

        public int Quantity { get; set; }

        public long? WorkOrderId { get; set; }

        public bool IsDeleted { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual NWC_CustomerAccount NWC_CustomerAccount { get; set; }

        public virtual NWC_StateWorkOrder NWC_StateWorkOrder { get; set; }
    }
}

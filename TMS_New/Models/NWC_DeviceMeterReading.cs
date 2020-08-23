namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_DeviceMeterReading
    {
        public long ID { get; set; }

        public long DeviceMeterID { get; set; }

        public decimal MeterReading { get; set; }

        public DateTime ReadingTime { get; set; }

        [StringLength(1000)]
        public string ReadingComment { get; set; }

        public bool IsDeleted { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? DetetedBy { get; set; }

        public DateTime? DeletedDate { get; set; }

        public virtual NWC_DeviceMeter NWC_DeviceMeter { get; set; }
    }
}

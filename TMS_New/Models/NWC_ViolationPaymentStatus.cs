namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_ViolationPaymentStatus
    {
        public long ID { get; set; }

        [StringLength(500)]
        public string NameAr { get; set; }

        [StringLength(500)]
        public string NameEn { get; set; }

        public Guid SubID { get; set; }
    }
}

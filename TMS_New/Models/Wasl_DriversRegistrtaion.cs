namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Wasl_DriversRegistrtaion
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string IdentityNumber { get; set; }

        public DateTime? BOD { get; set; }

        [StringLength(50)]
        public string MobileNumber { get; set; }

        public Guid? StuffId { get; set; }

        public DateTime? SyncDate { get; set; }

        public Guid? SyncBy { get; set; }

        public bool? success { get; set; }

        [StringLength(50)]
        public string resultCode { get; set; }

        [StringLength(50)]
        public string referenceKey { get; set; }

        public bool? isValid { get; set; }

        public string rejectionReason { get; set; }
    }
}

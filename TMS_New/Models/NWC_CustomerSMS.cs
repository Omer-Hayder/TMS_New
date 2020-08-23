namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_CustomerSMS
    {
        public long ID { get; set; }

        [Required]
        [StringLength(50)]
        public string OrderNumber { get; set; }

        public Guid VehicleID { get; set; }

        public Guid DriverID { get; set; }

        [Required]
        [StringLength(50)]
        public string DriverMobileNo { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerMobileNo { get; set; }

        [StringLength(1000)]
        public string SMSText { get; set; }

        public DateTime CreatedTime { get; set; }

        public int StatusID { get; set; }

        public DateTime? SentTime { get; set; }

        public string FailureMessage { get; set; }
    }
}

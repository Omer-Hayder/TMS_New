namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_CustomerLocationBalance
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string Code { get; set; }

        public long? BalanceLimit { get; set; }

        public long CustomerLocationID { get; set; }

        public int ServiceTypeID { get; set; }

        public int PaymentTypeID { get; set; }

        public int BalanceUniteID { get; set; }

        public virtual NWC_BalanceUnit NWC_BalanceUnit { get; set; }

        public virtual NWC_CustomerLocation NWC_CustomerLocation { get; set; }

        public virtual NWC_PaymentType NWC_PaymentType { get; set; }

        public virtual NWC_ServiceType NWC_ServiceType { get; set; }
    }
}

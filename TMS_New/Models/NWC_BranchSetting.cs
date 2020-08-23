namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_BranchSetting
    {
        [Key]
        public Guid BranchID { get; set; }

        public bool? ShowPrice { get; set; }

        public bool? ShowInvoice { get; set; }

        public int? TankerQuotaNo { get; set; }
    }
}

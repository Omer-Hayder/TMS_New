namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vendor_Items
    {
        public long ID { get; set; }

        [Required]
        public string ItemCode { get; set; }

        public string ItemDescription { get; set; }

        public decimal? ItemPrice { get; set; }

        public long VendorID { get; set; }

        public Guid CarTypeId { get; set; }

        public bool IsActive { get; set; }

        public Guid? SubID { get; set; }

        public virtual Maintenance_Vendors Maintenance_Vendors { get; set; }

        public virtual TransporterType TransporterType { get; set; }
    }
}

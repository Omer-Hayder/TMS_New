namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SystemSetting
    {
        [Key]
        public Guid UserID { get; set; }

        [StringLength(50)]
        public string SiteName { get; set; }

        [StringLength(50)]
        public string DefaultEmail { get; set; }

        [StringLength(50)]
        public string DateFormat { get; set; }

        [StringLength(50)]
        public string TimeZoneID { get; set; }

        public int? AdjustmentTypeID { get; set; }

        public int? BrandID { get; set; }

        public int? CalculationTypeID { get; set; }

        public int? CategoryID { get; set; }

        public int? CityID { get; set; }

        public long? CustomerID { get; set; }

        public int? GroupID { get; set; }

        public int? OrderStatusID { get; set; }

        public int? PaymentID { get; set; }

        public int? PriceTypeID { get; set; }

        public int? SizeID { get; set; }

        public int? ProductUnitID { get; set; }

        public int? ProjectID { get; set; }

        public long? SupplierID { get; set; }

        public int? TaxID { get; set; }

        public int? TransferTypeID { get; set; }

        public int? MinQty { get; set; }

        public int? SLReferenceFormatID { get; set; }

        public virtual SLReferenceFormat SLReferenceFormat { get; set; }

        public virtual User User { get; set; }
    }
}

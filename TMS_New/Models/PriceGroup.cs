namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PriceGroup")]
    public partial class PriceGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PriceGroup()
        {
            PriceLists = new HashSet<PriceList>();
        }

        public int PriceGroupID { get; set; }

        [Required]
        [StringLength(90)]
        public string PriceGroupName { get; set; }

        public DateTime PriceFrom { get; set; }

        public DateTime? PriceTo { get; set; }

        public bool Status { get; set; }

        public bool PricingType { get; set; }

        public int? PriceTypeID { get; set; }

        public bool? Add1Type { get; set; }

        public decimal? Add1 { get; set; }

        public bool? Add2Type { get; set; }

        public decimal? Add2 { get; set; }

        public bool? DiscountType { get; set; }

        public decimal? Discount_ { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastModified { get; set; }

        public Guid UserID { get; set; }

        public virtual PriceType PriceType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PriceList> PriceLists { get; set; }
    }
}

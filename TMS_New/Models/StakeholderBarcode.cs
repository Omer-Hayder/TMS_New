namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StakeholderBarcode")]
    public partial class StakeholderBarcode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal BarcodeID { get; set; }

        public long StakeholderID { get; set; }

        public decimal ProductNo { get; set; }

        [Required]
        [StringLength(15)]
        public string StakeholderType { get; set; }

        [Required]
        [StringLength(15)]
        public string BarcodeType { get; set; }

        [Required]
        [StringLength(50)]
        public string Barcode { get; set; }

        [StringLength(50)]
        public string OfferNo { get; set; }

        public virtual Product Product { get; set; }
    }
}

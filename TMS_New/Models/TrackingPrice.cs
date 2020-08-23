namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrackingPrice")]
    public partial class TrackingPrice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal PriceID { get; set; }

        public decimal ProductNo { get; set; }

        public decimal Price { get; set; }

        [Required]
        [StringLength(45)]
        public string Seller { get; set; }

        public DateTime InsertionDate { get; set; }

        public bool BuyButton { get; set; }

        public bool IsDelivery { get; set; }

        public int WebsiteID { get; set; }

        public int StoreID { get; set; }

        public decimal? BarcodeID { get; set; }

        public virtual Product Product { get; set; }

        public virtual Store Store { get; set; }
    }
}

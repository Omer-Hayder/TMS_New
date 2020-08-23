namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Adjustments = new HashSet<Adjustment>();
            ComboItems = new HashSet<ComboItem>();
            ComboItems1 = new HashSet<ComboItem>();
            CountProducts = new HashSet<CountProduct>();
            DeliveryOrderDetails = new HashSet<DeliveryOrderDetail>();
            OrderDetails = new HashSet<OrderDetail>();
            PriceLists = new HashSet<PriceList>();
            SaleOrderDetails = new HashSet<SaleOrderDetail>();
            StakeholderBarcodes = new HashSet<StakeholderBarcode>();
            StockOnHands = new HashSet<StockOnHand>();
            TrackingPrices = new HashSet<TrackingPrice>();
            TransferItems = new HashSet<TransferItem>();
            Stores = new HashSet<Store>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ProductNo { get; set; }

        [Required]
        [StringLength(150)]
        public string ProductEName { get; set; }

        [Required]
        [StringLength(150)]
        public string ProductAName { get; set; }

        [Required]
        [StringLength(15)]
        public string ProductCode { get; set; }

        public string SuppSuggestion { get; set; }

        [Required]
        [StringLength(70)]
        public string Barcode { get; set; }

        public int? CategoryID { get; set; }

        public int? GroupID { get; set; }

        [StringLength(20)]
        public string Model { get; set; }

        [StringLength(250)]
        public string BrandTag { get; set; }

        [StringLength(250)]
        public string Tag { get; set; }

        public decimal? MinQty { get; set; }

        [StringLength(7)]
        public string ProductColor { get; set; }

        public int? TaxID { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(150)]
        public string ProductImage { get; set; }

        public Guid? UserID { get; set; }

        public DateTime? InsertDate { get; set; }

        public int? ProductUnitID { get; set; }

        public int? SizeID { get; set; }

        public int? BrandID { get; set; }

        public int? ProjectID { get; set; }

        [StringLength(50)]
        public string SouqASN { get; set; }

        public int? ProductTypeID { get; set; }

        public bool? Active { get; set; }

        [StringLength(150)]
        public string ProductImageMini { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adjustment> Adjustments { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComboItem> ComboItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComboItem> ComboItems1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CountProduct> CountProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryOrderDetail> DeliveryOrderDetails { get; set; }

        public virtual Group Group { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PriceList> PriceLists { get; set; }

        public virtual ProductSize ProductSize { get; set; }

        public virtual ProductUnit ProductUnit { get; set; }

        public virtual Project Project { get; set; }

        public virtual Tax Tax { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleOrderDetail> SaleOrderDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StakeholderBarcode> StakeholderBarcodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockOnHand> StockOnHands { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackingPrice> TrackingPrices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransferItem> TransferItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store> Stores { get; set; }
    }
}

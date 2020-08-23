namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Supplier")]
    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            PurchaseOrders = new HashSet<PurchaseOrder>();
        }

        public long SupplierID { get; set; }

        [Required]
        [StringLength(150)]
        public string Company { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(50)]
        public string VATNumber { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(10)]
        public string Phone { get; set; }

        public int? CityID { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(6)]
        public string PostalCode { get; set; }

        [StringLength(10)]
        public string Telephone { get; set; }

        public DateTime? CreationDate { get; set; }

        public Guid? UserID { get; set; }

        public int? ProjectID { get; set; }

        public int? PaymentID { get; set; }

        public virtual City City { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }

        public virtual Project Project { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }

        public virtual User User { get; set; }
    }
}

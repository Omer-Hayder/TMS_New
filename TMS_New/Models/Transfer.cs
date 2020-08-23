namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transfer")]
    public partial class Transfer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transfer()
        {
            TransferItems = new HashSet<TransferItem>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal TransferID { get; set; }

        [Required]
        [StringLength(10)]
        public string ReferenceNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime TransferDate { get; set; }

        public int FromWarehouse { get; set; }

        public int ToWarehouse { get; set; }

        public int TransferTypeID { get; set; }

        public decimal Shipping { get; set; }

        [StringLength(250)]
        public string AttachedFile { get; set; }

        [StringLength(250)]
        public string Note { get; set; }

        public DateTime CreationDate { get; set; }

        public Guid UserID { get; set; }

        public virtual User User { get; set; }

        public virtual Warehouse Warehouse { get; set; }

        public virtual Warehouse Warehouse1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransferItem> TransferItems { get; set; }
    }
}

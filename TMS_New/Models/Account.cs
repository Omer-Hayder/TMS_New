namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            Account1 = new HashSet<Account>();
            Expenses = new HashSet<Expense>();
        }

        [Key]
        public int AccID { get; set; }

        [Required]
        [StringLength(6)]
        public string AccCode { get; set; }

        [Required]
        [StringLength(150)]
        public string AccEName { get; set; }

        [StringLength(150)]
        public string AccAName { get; set; }

        public int? ParentID { get; set; }

        public int AccTypeID { get; set; }

        public decimal? OpenBal { get; set; }

        [Column(TypeName = "date")]
        public DateTime AccDate { get; set; }

        public string Description { get; set; }

        public int AccActive { get; set; }

        public Guid UserID { get; set; }

        public DateTime CreateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> Account1 { get; set; }

        public virtual Account Account2 { get; set; }

        public virtual AccType AccType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Expense> Expenses { get; set; }
    }
}

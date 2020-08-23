namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Expense")]
    public partial class Expense
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ExpenseID { get; set; }

        [Required]
        [StringLength(10)]
        public string ExpenseCode { get; set; }

        [Required]
        [StringLength(25)]
        public string ReferenceNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime ExpenseDate { get; set; }

        public int AccID { get; set; }

        public int ProjectID { get; set; }

        [Required]
        [StringLength(250)]
        public string Description { get; set; }

        public int TaxID { get; set; }

        public decimal ExpenseAmount { get; set; }

        public decimal VatAmount { get; set; }

        public decimal AmountWithVAT { get; set; }

        public string Note { get; set; }

        [StringLength(250)]
        public string AttachedFile { get; set; }

        [StringLength(250)]
        public string Tags { get; set; }

        public DateTime ActualDate { get; set; }

        public Guid UserID { get; set; }

        public virtual Account Account { get; set; }

        public virtual Project Project { get; set; }

        public virtual User User { get; set; }
    }
}

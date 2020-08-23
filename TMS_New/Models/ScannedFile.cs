namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ScannedFile")]
    public partial class ScannedFile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ScanID { get; set; }

        [StringLength(250)]
        public string ScanTitle { get; set; }

        public int InvoiceTypeID { get; set; }

        public decimal InvoiceID { get; set; }

        [Required]
        public string AttachedFile { get; set; }

        public DateTime? CreationDate { get; set; }

        public Guid? UserID { get; set; }

        public virtual InvoiceType InvoiceType { get; set; }
    }
}

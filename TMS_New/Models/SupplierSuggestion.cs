namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SupplierSuggestion")]
    public partial class SupplierSuggestion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal SupSugID { get; set; }

        [Required]
        [StringLength(150)]
        public string SupSugName { get; set; }
    }
}

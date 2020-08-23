namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ComboItem")]
    public partial class ComboItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ComboID { get; set; }

        public decimal ProductNo { get; set; }

        public decimal ItemID { get; set; }

        public int Qty { get; set; }

        public virtual Product Product { get; set; }

        public virtual Product Product1 { get; set; }
    }
}

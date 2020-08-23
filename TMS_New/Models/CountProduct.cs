namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CountProduct")]
    public partial class CountProduct
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CountStockID { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ProductNo { get; set; }

        public int Count { get; set; }

        public virtual CountStock CountStock { get; set; }

        public virtual Product Product { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PriceList")]
    public partial class PriceList
    {
        [Key]
        [Column(Order = 0)]
        public decimal ProductNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PriceGroupID { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public DateTime LastModified { get; set; }

        public Guid UserID { get; set; }

        public virtual PriceGroup PriceGroup { get; set; }

        public virtual Product Product { get; set; }

        public virtual User User { get; set; }
    }
}

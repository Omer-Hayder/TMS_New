namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TransferItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        public decimal TransferID { get; set; }

        public decimal ProductNo { get; set; }

        public int RowID { get; set; }

        public decimal Quantity { get; set; }

        public DateTime? CreationDate { get; set; }

        public Guid? UserID { get; set; }

        public virtual Product Product { get; set; }

        public virtual Transfer Transfer { get; set; }

        public virtual User User { get; set; }
    }
}

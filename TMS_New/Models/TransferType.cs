namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransferType")]
    public partial class TransferType
    {
        public int TransferTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string TransferTypeName { get; set; }
    }
}

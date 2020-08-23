namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmailVerifier")]
    public partial class EmailVerifier
    {
        public int id { get; set; }

        [StringLength(500)]
        public string ReceiverEmail { get; set; }

        public int? isProcessed { get; set; }

        public int? isValid { get; set; }

        public Guid? userId { get; set; }

        [Column(TypeName = "text")]
        public string strError { get; set; }
    }
}

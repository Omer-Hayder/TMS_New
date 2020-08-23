namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CheckInOutTransaction_AttachedFile
    {
        [Key]
        public long Serial { get; set; }

        public long AttachedFileId { get; set; }

        public Guid CheckInOutTransactionId { get; set; }

        public virtual AttachedFile AttachedFile { get; set; }

        public virtual CheckInOutTransaction CheckInOutTransaction { get; set; }
    }
}

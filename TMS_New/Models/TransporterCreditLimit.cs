namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransporterCreditLimit")]
    public partial class TransporterCreditLimit
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Guid? SubID { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreationTime { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public bool? Isdeleted { get; set; }

        public DateTime? LastModificationDate { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_ContractAttachment
    {
        public long ID { get; set; }

        public long ContractID { get; set; }

        [Required]
        public string RelativePath { get; set; }

        public bool IsDeleted { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? DeletedBy { get; set; }

        public DateTime? DeletedDate { get; set; }

        [StringLength(200)]
        public string DocumentName { get; set; }

        public virtual NWC_Contract NWC_Contract { get; set; }
    }
}

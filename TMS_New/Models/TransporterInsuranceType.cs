namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransporterInsuranceType")]
    public partial class TransporterInsuranceType
    {
        public Guid ID { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public bool? IsDeleted { get; set; }

        [StringLength(100)]
        public string NameAr { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(500)]
        public string DescriptionAr { get; set; }
    }
}

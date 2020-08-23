namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Insurance_Companies
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public Guid SubID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string MobileNumber { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransporterLicenseType")]
    public partial class TransporterLicenseType
    {
        public long Id { get; set; }

        public string NameEn { get; set; }

        public string NameAr { get; set; }

        public string DecriptionEn { get; set; }

        public string DecriptionAr { get; set; }

        public bool? IsDeleted { get; set; }

        public long? ExternalSystemId { get; set; }
    }
}

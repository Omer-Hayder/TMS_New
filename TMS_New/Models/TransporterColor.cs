namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransporterColor")]
    public partial class TransporterColor
    {
        public long Id { get; set; }

        public string NameEn { get; set; }

        public string NameAr { get; set; }

        public string DecriptionEn { get; set; }

        public string DecriptionAr { get; set; }

        public bool? IsDeleted { get; set; }

        public string HexaCode { get; set; }
    }
}

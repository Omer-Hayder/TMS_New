namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_StatusReason
    {
        public int ID { get; set; }

        [Required]
        [StringLength(1000)]
        public string ReasonAr { get; set; }

        [Required]
        [StringLength(1000)]
        public string ReasonEn { get; set; }

        public int StatusID { get; set; }

        [StringLength(50)]
        public string IntegrationId { get; set; }

        public virtual TransporterStatu TransporterStatu { get; set; }
    }
}

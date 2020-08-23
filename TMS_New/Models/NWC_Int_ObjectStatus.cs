namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_Int_ObjectStatus
    {
        public long ID { get; set; }

        [Required]
        [StringLength(20)]
        public string OrderNumber { get; set; }

        public int? StatusID { get; set; }

        public DateTime? StatusTime { get; set; }

        public int? OperationTypeID { get; set; }

        public string DTO { get; set; }

        public string XML { get; set; }

        public string Token { get; set; }

        public int Retrials { get; set; }

        public string FailureMessage { get; set; }
    }
}

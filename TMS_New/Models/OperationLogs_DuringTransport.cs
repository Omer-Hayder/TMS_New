namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OperationLogs_DuringTransport
    {
        public Guid ID { get; set; }

        public Guid CaseId { get; set; }

        [StringLength(50)]
        public string Hour { get; set; }

        [StringLength(50)]
        public string Pulse { get; set; }

        [StringLength(50)]
        public string Temperature { get; set; }

        [StringLength(50)]
        public string RR { get; set; }

        [StringLength(10)]
        public string O2Saturation { get; set; }

        public DateTime CreationTime { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid? ModifyedBy { get; set; }

        public DateTime? ModificationTime { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        public virtual aspnet_Users aspnet_Users1 { get; set; }
    }
}

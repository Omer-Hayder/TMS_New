namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OperationLogs_Drugs
    {
        public Guid ID { get; set; }

        public Guid CaseID { get; set; }

        [StringLength(50)]
        public string Drugs { get; set; }

        public DateTime? TimeOfSarted { get; set; }

        [StringLength(50)]
        public string DosePerKg { get; set; }

        public DateTime? LastDoseGiven { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public Guid? ModifyedBy { get; set; }

        public DateTime? ModificationTime { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        public virtual aspnet_Users aspnet_Users1 { get; set; }
    }
}

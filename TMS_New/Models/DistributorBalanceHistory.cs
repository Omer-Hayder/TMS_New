namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DistributorBalanceHistory")]
    public partial class DistributorBalanceHistory
    {
        public Guid ID { get; set; }

        public Guid? distributor { get; set; }

        public double? credit { get; set; }

        public double? debit { get; set; }

        public double? balance { get; set; }

        public DateTime? date { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreationTime { get; set; }

        [StringLength(4000)]
        public string description { get; set; }

        public virtual Distributor Distributor1 { get; set; }
    }
}

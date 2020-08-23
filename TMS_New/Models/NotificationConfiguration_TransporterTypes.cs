namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NotificationConfiguration_TransporterTypes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NotificationConfiguration { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid TransporterType { get; set; }

        public virtual NotificationConfiguration NotificationConfiguration1 { get; set; }

        public virtual TransporterType TransporterType1 { get; set; }
    }
}

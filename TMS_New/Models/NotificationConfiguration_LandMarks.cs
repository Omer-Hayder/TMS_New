namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NotificationConfiguration_LandMarks
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NotificationConfiguration { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid LandMark { get; set; }

        public virtual Landmark Landmark1 { get; set; }

        public virtual NotificationConfiguration NotificationConfiguration1 { get; set; }
    }
}

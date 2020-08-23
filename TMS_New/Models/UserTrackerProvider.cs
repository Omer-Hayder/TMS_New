namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserTrackerProvider")]
    public partial class UserTrackerProvider
    {
        [Key]
        [Column(Order = 0)]
        public Guid UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ProviderID { get; set; }

        public DateTime? CreationDate { get; set; }

        public bool IsDeleted { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }
    }
}

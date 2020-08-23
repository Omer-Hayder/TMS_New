namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserPassword")]
    public partial class UserPassword
    {
        public Guid ID { get; set; }

        public Guid? UserId { get; set; }

        public Guid? SubId { get; set; }

        [StringLength(128)]
        public string Password { get; set; }

        public DateTime? CreationDate { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        public virtual Subscriber Subscriber { get; set; }
    }
}

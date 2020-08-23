namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MailActions_Users
    {
        public Guid ID { get; set; }

        public Guid user { get; set; }

        public Guid mailAction { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        public virtual MailAction MailAction1 { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SubscriberDisabledReport
    {
        public Guid Id { get; set; }

        public Guid? SubId { get; set; }

        public Guid? ReportId { get; set; }

        public virtual Report Report { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PS_EmptyTemplateSerials
    {
        [Key]
        public Guid StaffId { get; set; }

        public Guid SubId { get; set; }

        public long Serial { get; set; }

        public int pading { get; set; }
    }
}

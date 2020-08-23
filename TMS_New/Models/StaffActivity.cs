namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StaffActivity")]
    public partial class StaffActivity
    {
        public Guid Id { get; set; }

        public Guid StaffId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public byte Type { get; set; }

        public Guid? ProjectId { get; set; }

        public string Descreption { get; set; }

        public virtual Staff Staff { get; set; }
    }
}

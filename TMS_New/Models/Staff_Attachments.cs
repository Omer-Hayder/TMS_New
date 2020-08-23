namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Staff_Attachments
    {
        public int ID { get; set; }

        public string File { get; set; }

        public string FileName { get; set; }

        public Guid? StaffId { get; set; }

        public Guid? UserId { get; set; }

        public DateTime? DateIn { get; set; }

        public bool? Isdeleted { get; set; }

        public Guid? Modifiedby { get; set; }

        public DateTime? ModificationDate { get; set; }

        public virtual Staff Staff { get; set; }
    }
}

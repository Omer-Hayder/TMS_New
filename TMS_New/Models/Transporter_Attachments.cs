namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transporter_Attachments
    {
        public long ID { get; set; }

        public string File { get; set; }

        public string FileName { get; set; }

        public Guid? TransporterId { get; set; }

        public Guid UserId { get; set; }

        public DateTime? DateIn { get; set; }

        public bool? Isdeleted { get; set; }

        public Guid? Modifiedby { get; set; }

        public DateTime? ModificationDate { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transporter_TransporterGroup
    {
        public Guid Id { get; set; }

        public Guid TransporterId { get; set; }

        public Guid TransporterGroupId { get; set; }

        public virtual TransporterGroup TransporterGroup { get; set; }
    }
}

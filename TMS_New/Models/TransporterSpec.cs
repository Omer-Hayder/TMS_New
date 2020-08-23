namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransporterSpec")]
    public partial class TransporterSpec
    {
        public long Id { get; set; }

        public long? TransporterSpecsId { get; set; }

        public long? NumberOfSpec { get; set; }

        public Guid? TransporterId { get; set; }

        public virtual Lookup_TransporterSpecs Lookup_TransporterSpecs { get; set; }
    }
}

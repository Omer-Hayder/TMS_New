namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Offer_Module
    {
        public Guid ID { get; set; }

        public Guid offer { get; set; }

        public Guid module { get; set; }

        public virtual Module Module1 { get; set; }

        public virtual Offer Offer1 { get; set; }
    }
}

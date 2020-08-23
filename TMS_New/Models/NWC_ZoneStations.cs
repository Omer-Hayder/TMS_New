namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_ZoneStations
    {
        public long ID { get; set; }

        public long ZoneID { get; set; }

        public Guid StationID { get; set; }

        public bool IsMain { get; set; }

        public decimal? Distance { get; set; }

        public virtual Landmark Landmark { get; set; }

        public virtual NWC_Zone NWC_Zone { get; set; }
    }
}

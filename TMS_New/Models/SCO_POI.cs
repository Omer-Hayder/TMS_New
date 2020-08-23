namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SCO_POI
    {
        public long Id { get; set; }

        public long StudentId { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public int POITypeId { get; set; }

        public bool IsDeleted { get; set; }

        public int? BufferSize { get; set; }

        public virtual SCO_POIType SCO_POIType { get; set; }

        public virtual SCO_Students SCO_Students { get; set; }
    }
}

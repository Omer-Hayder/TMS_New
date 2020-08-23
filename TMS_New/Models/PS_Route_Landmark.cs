namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PS_Route_Landmark
    {
        public long Id { get; set; }

        public long? RouteId { get; set; }

        public Guid? LandmarkId { get; set; }

        public int? Landmark_Order { get; set; }

        public virtual Landmark Landmark { get; set; }

        public virtual PS_Route PS_Route { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserSetting
    {
        [Key]
        public Guid UserID { get; set; }

        public double? MapCenterLat { get; set; }

        public double? MapCenterLong { get; set; }

        public int? DefaultGoogleMap { get; set; }

        public int? ShowCodePlate { get; set; }

        public int? ZoomLevel { get; set; }

        public bool? ShowGeofenceWhenEnter { get; set; }

        public bool? ShowAllLandmarksByDefault { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SCO_Holidays
    {
        public int Id { get; set; }

        public DateTime HolidayDate { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public bool IsDeleted { get; set; }
    }
}

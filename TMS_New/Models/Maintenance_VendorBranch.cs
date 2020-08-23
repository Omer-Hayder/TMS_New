namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Maintenance_VendorBranch
    {
        public long ID { get; set; }

        [Required]
        public string Name { get; set; }

        public bool IsMainBranch { get; set; }

        [Required]
        public string Email1 { get; set; }

        public string Email2 { get; set; }

        [Required]
        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        [Required]
        public string Address { get; set; }

        public bool? IsActive { get; set; }

        public Guid Createdby { get; set; }

        public DateTime? CreatedTime { get; set; }

        public Guid? Updatedby { get; set; }

        public DateTime? UpdateTime { get; set; }

        public long VendorId { get; set; }

        public Guid? SubId { get; set; }

        public Guid? Branch { get; set; }

        public virtual Branch Branch1 { get; set; }

        public virtual Maintenance_VendorBranch Maintenance_VendorBranch1 { get; set; }

        public virtual Maintenance_VendorBranch Maintenance_VendorBranch2 { get; set; }

        public virtual Maintenance_Vendors Maintenance_Vendors { get; set; }
    }
}

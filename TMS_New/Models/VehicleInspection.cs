namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehicleInspection")]
    public partial class VehicleInspection
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VehicleInspection()
        {
            Transaction_VehicleInspection = new HashSet<Transaction_VehicleInspection>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public bool? IsDeleted { get; set; }

        public Guid? SubID { get; set; }

        public DateTime? CreationTime { get; set; }

        public Guid? Createdby { get; set; }

        public DateTime? ModificationTime { get; set; }

        public Guid? ModifiedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction_VehicleInspection> Transaction_VehicleInspection { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaintenanceDriverRole")]
    public partial class MaintenanceDriverRole
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MaintenanceDriverRole()
        {
            CheckInOutTransactions = new HashSet<CheckInOutTransaction>();
            RequestForRepairs = new HashSet<RequestForRepair>();
        }

        public int Id { get; set; }

        public string NameAr { get; set; }

        public string NameEn { get; set; }

        public Guid? SubId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckInOutTransaction> CheckInOutTransactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestForRepair> RequestForRepairs { get; set; }
    }
}

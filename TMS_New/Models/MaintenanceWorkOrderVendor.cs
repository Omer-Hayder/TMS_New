namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaintenanceWorkOrderVendor")]
    public partial class MaintenanceWorkOrderVendor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MaintenanceWorkOrderVendor()
        {
            MaintenancePMs = new HashSet<MaintenancePM>();
            MaintenanceWorkOrders = new HashSet<MaintenanceWorkOrder>();
            Transporter_ContractData = new HashSet<Transporter_ContractData>();
            aspnet_Users = new HashSet<aspnet_Users>();
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public Guid? SubID { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? CreationTime { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public bool? Isdeleted { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public int? Type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenancePM> MaintenancePMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenanceWorkOrder> MaintenanceWorkOrders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transporter_ContractData> Transporter_ContractData { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<aspnet_Users> aspnet_Users { get; set; }
    }
}

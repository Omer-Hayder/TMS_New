namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MaintenanceSparePart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MaintenanceSparePart()
        {
            MaintenaceProblemSparPartsAssigns = new HashSet<MaintenaceProblemSparPartsAssign>();
        }

        public Guid ID { get; set; }

        public string SparePartSerial { get; set; }

        public Guid? SparePartCategory { get; set; }

        public DateTime CreationTime { get; set; }

        public Guid CreatedBy { get; set; }

        public double? Price { get; set; }

        public bool? isAssigned { get; set; }

        public bool? isDeleted { get; set; }

        public string deletionReason { get; set; }

        public DateTime? lastModificationDate { get; set; }

        public Guid? lastModifiedBy { get; set; }

        public int? productionYear { get; set; }

        public Guid SubID { get; set; }

        public string Name { get; set; }

        public bool? IsPurchasing { get; set; }

        [StringLength(250)]
        public string Supplier_Info { get; set; }

        public int? Quantity { get; set; }

        public Guid? Supplier_Info_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenaceProblemSparPartsAssign> MaintenaceProblemSparPartsAssigns { get; set; }

        public virtual SparePartCategory SparePartCategory1 { get; set; }

        public virtual SupplierInfo SupplierInfo { get; set; }
    }
}

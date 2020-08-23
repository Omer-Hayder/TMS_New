namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_CustomerLocationClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NWC_CustomerLocationClass()
        {
            NWC_ContractPrice = new HashSet<NWC_ContractPrice>();
            NWC_ContractTariff = new HashSet<NWC_ContractTariff>();
            NWC_CustomerLocation = new HashSet<NWC_CustomerLocation>();
            NWC_StationCustomerLocationClass = new HashSet<NWC_StationCustomerLocationClass>();
            NWC_VehicleCustomerLocationClass = new HashSet<NWC_VehicleCustomerLocationClass>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(500)]
        public string NameAr { get; set; }

        [StringLength(500)]
        public string NameEn { get; set; }

        public Guid SubID { get; set; }

        [StringLength(50)]
        public string IntegrationId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_ContractPrice> NWC_ContractPrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_ContractTariff> NWC_ContractTariff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_CustomerLocation> NWC_CustomerLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_StationCustomerLocationClass> NWC_StationCustomerLocationClass { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_VehicleCustomerLocationClass> NWC_VehicleCustomerLocationClass { get; set; }
    }
}

namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NWC_ServiceType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NWC_ServiceType()
        {
            NWC_ContractPrice = new HashSet<NWC_ContractPrice>();
            NWC_ContractTariff = new HashSet<NWC_ContractTariff>();
            NWC_CustomerAccount = new HashSet<NWC_CustomerAccount>();
            NWC_CustomerLocationBalance = new HashSet<NWC_CustomerLocationBalance>();
            NWC_StationServiceType = new HashSet<NWC_StationServiceType>();
            NWC_UserServicePermission = new HashSet<NWC_UserServicePermission>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string TypeAr { get; set; }

        [StringLength(50)]
        public string TypeEn { get; set; }

        public Guid SubID { get; set; }

        [StringLength(50)]
        public string IntegrationId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_ContractPrice> NWC_ContractPrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_ContractTariff> NWC_ContractTariff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_CustomerAccount> NWC_CustomerAccount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_CustomerLocationBalance> NWC_CustomerLocationBalance { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_StationServiceType> NWC_StationServiceType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_UserServicePermission> NWC_UserServicePermission { get; set; }
    }
}

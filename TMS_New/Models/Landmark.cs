namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Landmark")]
    public partial class Landmark
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Landmark()
        {
            InspectionDetails = new HashSet<InspectionDetail>();
            LandmarkDynamicAttributeMaps = new HashSet<LandmarkDynamicAttributeMap>();
            NotificationConfiguration_LandMarks = new HashSet<NotificationConfiguration_LandMarks>();
            NWC_ContractPrice = new HashSet<NWC_ContractPrice>();
            NWC_ContractStations = new HashSet<NWC_ContractStations>();
            NWC_ContractStationViolation = new HashSet<NWC_ContractStationViolation>();
            NWC_ContractTariff = new HashSet<NWC_ContractTariff>();
            NWC_ContractTerms = new HashSet<NWC_ContractTerms>();
            NWC_DeviceMeter = new HashSet<NWC_DeviceMeter>();
            NWC_ContractAccessory = new HashSet<NWC_ContractAccessory>();
            NWC_StationCustomerLocationClass = new HashSet<NWC_StationCustomerLocationClass>();
            NWC_StationServiceType = new HashSet<NWC_StationServiceType>();
            NWC_UserLandmarkPermission = new HashSet<NWC_UserLandmarkPermission>();
            NWC_ZoneStations = new HashSet<NWC_ZoneStations>();
            OperationWorkOrderLandmarks = new HashSet<OperationWorkOrderLandmark>();
            OperationWorkOrderLandmarks1 = new HashSet<OperationWorkOrderLandmark>();
            Paths = new HashSet<Path>();
            Paths1 = new HashSet<Path>();
            PS_OperationWorkOrder_Landmark = new HashSet<PS_OperationWorkOrder_Landmark>();
            PS_OperationWorkOrderLocationHistory = new HashSet<PS_OperationWorkOrderLocationHistory>();
            PS_Route_Landmark = new HashSet<PS_Route_Landmark>();
            RequestForRepairs = new HashSet<RequestForRepair>();
            SCO_PlannedTrip = new HashSet<SCO_PlannedTrip>();
            SCO_PlannedTrip1 = new HashSet<SCO_PlannedTrip>();
            Staffs = new HashSet<Staff>();
            WorkOrderLandmarks = new HashSet<WorkOrderLandmark>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [StringLength(4000)]
        public string descr { get; set; }

        [StringLength(100)]
        public string code { get; set; }

        public Guid? landmarkTypeId { get; set; }

        [StringLength(100)]
        public string landmarkTypeName { get; set; }

        public Guid? branchId { get; set; }

        [StringLength(4000)]
        public string address { get; set; }

        [StringLength(50)]
        public string telephone { get; set; }

        [StringLength(50)]
        public string telephone2 { get; set; }

        [StringLength(50)]
        public string mobile { get; set; }

        [StringLength(50)]
        public string fax { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? latitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? longitude { get; set; }

        public Guid? contactPerson { get; set; }

        public Guid SubId { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public bool? isDeleted { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public Guid? GeofenceId { get; set; }

        public int? AVGAddonFillingTime { get; set; }

        public int? WaterSourceID { get; set; }

        public int? StationOwnershipID { get; set; }

        public int? StatusID { get; set; }

        [StringLength(50)]
        public string IntegrationId { get; set; }

        public virtual Branch Branch { get; set; }

        public virtual ContactPerson ContactPerson1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InspectionDetail> InspectionDetails { get; set; }

        public virtual LandmarkType LandmarkType { get; set; }

        public virtual NWC_StationOwnership NWC_StationOwnership { get; set; }

        public virtual NWC_StationStatus NWC_StationStatus { get; set; }

        public virtual NWC_StationWaterSource NWC_StationWaterSource { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LandmarkDynamicAttributeMap> LandmarkDynamicAttributeMaps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationConfiguration_LandMarks> NotificationConfiguration_LandMarks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_ContractPrice> NWC_ContractPrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_ContractStations> NWC_ContractStations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_ContractStationViolation> NWC_ContractStationViolation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_ContractTariff> NWC_ContractTariff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_ContractTerms> NWC_ContractTerms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_DeviceMeter> NWC_DeviceMeter { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_ContractAccessory> NWC_ContractAccessory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_StationCustomerLocationClass> NWC_StationCustomerLocationClass { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_StationServiceType> NWC_StationServiceType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_UserLandmarkPermission> NWC_UserLandmarkPermission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NWC_ZoneStations> NWC_ZoneStations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationWorkOrderLandmark> OperationWorkOrderLandmarks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationWorkOrderLandmark> OperationWorkOrderLandmarks1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Path> Paths { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Path> Paths1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_OperationWorkOrder_Landmark> PS_OperationWorkOrder_Landmark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_OperationWorkOrderLocationHistory> PS_OperationWorkOrderLocationHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PS_Route_Landmark> PS_Route_Landmark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestForRepair> RequestForRepairs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_PlannedTrip> SCO_PlannedTrip { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCO_PlannedTrip> SCO_PlannedTrip1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff> Staffs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrderLandmark> WorkOrderLandmarks { get; set; }
    }
}

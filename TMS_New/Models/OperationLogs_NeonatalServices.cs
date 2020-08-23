namespace TMS_New.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OperationLogs_NeonatalServices
    {
        public Guid ID { get; set; }

        public Guid CaseId { get; set; }

        [StringLength(20)]
        public string SocialNumber { get; set; }

        [StringLength(20)]
        public string PatientMobNumber { get; set; }

        public bool? PointConversion_FromType { get; set; }

        public bool? PointConversion_ToType { get; set; }

        public Guid? PointConversion_HospitalFrom { get; set; }

        public Guid? PointConversion_HospitalTo { get; set; }

        public Guid? PointconversionGovernorate_From { get; set; }

        public Guid? PointconversionGovernorate_To { get; set; }

        [StringLength(20)]
        public string DoctorMobile_From { get; set; }

        [StringLength(20)]
        public string DoctorMobile_To { get; set; }

        public Guid? Doctor_From { get; set; }

        public Guid? Doctor_To { get; set; }

        public Guid? Paramedic { get; set; }

        public DateTime? ArrivalTime { get; set; }

        [StringLength(150)]
        public string MotherName { get; set; }

        [StringLength(150)]
        public string PlaceOfBirth { get; set; }

        public bool? MaternalConditions_DiabetesMellitus { get; set; }

        public bool? MaternalConditions_EssentialHypertension { get; set; }

        public bool? MaternalConditions_SLE { get; set; }

        public bool? MaternalConditions_Throid { get; set; }

        public string MaternalConditions_Others { get; set; }

        public bool? Antenatal_GestationalDiabetes { get; set; }

        public bool? Antenatal_HypertensionDuringPregnancy { get; set; }

        public bool? Antenatal_MultiplePregnancies { get; set; }

        public bool? Antenatal_Drugs { get; set; }

        public int? Antenatal_NumOFPregnancy { get; set; }

        public int? Antenatal_NumOfChildren { get; set; }

        public bool? Antenatal_PROM { get; set; }

        public short? PatientInfo_Gender { get; set; }

        public short? PatientInfo_TypeOfLabour { get; set; }

        public short? PatientInfo_AmnioticFluid { get; set; }

        [StringLength(50)]
        public string PatientInfo_GA { get; set; }

        [StringLength(50)]
        public string PatientInfo_Weight { get; set; }

        [StringLength(50)]
        public string PatientInfo_Length { get; set; }

        [StringLength(50)]
        public string PatientInfo_OPC { get; set; }

        [StringLength(100)]
        public string PatientInfo_APGAR { get; set; }

        public bool? PatientInfo_Intubated { get; set; }

        [StringLength(50)]
        public string Examination_Respiratory_BR { get; set; }

        [StringLength(50)]
        public string Examination_Respiratory_O2Sat { get; set; }

        public short? Examination_Respiratory_Color { get; set; }

        public bool? Examination_Respiratory_Apnea { get; set; }

        [StringLength(50)]
        public string Examination_CSV_HeartRate { get; set; }

        [StringLength(50)]
        public string Examination_CSV_Capillary { get; set; }

        public bool? Examination_CSV_Pulsation { get; set; }

        public bool? Examination_CSV_Murmurs { get; set; }

        public bool? Examination_Neuro_Conscious { get; set; }

        public short? Examination_Neuro_Activity { get; set; }

        public bool? Examination_Neuro_Convulsion { get; set; }

        public short? Examination_Neuro_Suckling { get; set; }

        [StringLength(50)]
        public string Examination_Neuro_Moro { get; set; }

        public bool? Examination_CIT_Destension { get; set; }

        public bool? Examination_CIT_Vomiting { get; set; }

        public bool? Examination_CIT_LSound { get; set; }

        public bool? Examination_CIT_Organomegally { get; set; }

        public bool? Examination_CIT_Rigidity { get; set; }

        public short? CauseOFReferral { get; set; }

        [StringLength(50)]
        public string CauseOFReferral_Others { get; set; }

        public short? InitialDiagnosis_Chest { get; set; }

        public short? InitialDiagnosis_Blood { get; set; }

        public short? InitialDiagnosis_CNS { get; set; }

        public short? InitialDiagnosis_GIT { get; set; }

        [StringLength(50)]
        public string InitialDiagnosis_Cardiac_Congential { get; set; }

        [StringLength(50)]
        public string InitialDiagnosis_Cardiac_Other { get; set; }

        [StringLength(50)]
        public string InitialDiagnosis_Chest_Other { get; set; }

        [StringLength(50)]
        public string InitialDiagnosis_Blood_Other { get; set; }

        [StringLength(50)]
        public string InitialDiagnosis_CNS_Other { get; set; }

        [StringLength(50)]
        public string InitialDiagnosis_GIT_Other { get; set; }

        public string OtherDiagnosis { get; set; }

        [StringLength(50)]
        public string VentilatedBaby_Mode { get; set; }

        [StringLength(50)]
        public string VentilatedBaby_PIP { get; set; }

        [StringLength(50)]
        public string VentilatedBaby_Peep { get; set; }

        [StringLength(50)]
        public string VentilatedBaby_TI { get; set; }

        [StringLength(50)]
        public string VentilatedBaby_Rate { get; set; }

        [StringLength(50)]
        public string VentilatedBaby_Fio2 { get; set; }

        [StringLength(50)]
        public string VentilatedBaby_LastABG_Pi { get; set; }

        [StringLength(50)]
        public string VentilatedBaby_LastABG_Faco2 { get; set; }

        [StringLength(50)]
        public string VentilatedBaby_LastABG_Pao2 { get; set; }

        [StringLength(50)]
        public string VentilatedBaby_LastABG_HCO3 { get; set; }

        [StringLength(50)]
        public string VentilatedBaby_LastABG_BE { get; set; }

        [StringLength(50)]
        public string VentilatedBaby_ETT_Size { get; set; }

        [StringLength(50)]
        public string VentilatedBaby_ETT_Length { get; set; }

        public DateTime? VentilatedBaby_ArrivalTime { get; set; }

        public Guid? VentilatedBaby_ConverterDoctor { get; set; }

        [StringLength(50)]
        public string VentilatedBaby_ETT_PhoneNumber { get; set; }

        public string DuringTransport_ImportantNotes { get; set; }

        [StringLength(50)]
        public string DuringTransport_VentilatedBaby_Mode { get; set; }

        [StringLength(50)]
        public string DuringTransport_VentilatedBaby_PIP { get; set; }

        [StringLength(50)]
        public string DuringTransport_VentilatedBaby_TI { get; set; }

        [StringLength(50)]
        public string DuringTransport_VentilatedBaby_Peep { get; set; }

        [StringLength(50)]
        public string DuringTransport_VentilatedBaby_TE { get; set; }

        [StringLength(50)]
        public string DuringTransport_VentilatedBaby_O2Flow { get; set; }

        [StringLength(50)]
        public string DuringTransport_VentilatedBaby_AirFlow { get; set; }

        [StringLength(50)]
        public string DuringTransport_ABG_Ph { get; set; }

        [StringLength(50)]
        public string DuringTransport_ABG_Paco2 { get; set; }

        [StringLength(50)]
        public string DuringTransport_ABG_HCO3 { get; set; }

        [StringLength(50)]
        public string DuringTransport_ABG_BE { get; set; }

        public Guid? DuringTransport_Doctor { get; set; }

        public DateTime? Recipient_ArrivalTime { get; set; }

        [StringLength(50)]
        public string ArrivalABG_Ph { get; set; }

        [StringLength(50)]
        public string ArrivalABG_Paco2 { get; set; }

        [StringLength(50)]
        public string ArrivalABG_Pao2 { get; set; }

        [StringLength(50)]
        public string ArrivalABG_HCO3 { get; set; }

        [StringLength(50)]
        public string ArrivalABG_BE { get; set; }

        public Guid? ArrivalABG_Doctor { get; set; }

        public Guid? ArrivalABG_Paramedic { get; set; }

        [StringLength(50)]
        public string ArrivalABG_PhoneNumber { get; set; }

        public DateTime? ArrivalABG_LeaveTime { get; set; }

        public bool? Drugs_FluiGlocose { get; set; }

        public bool? Drugs_BreastMilk { get; set; }

        [StringLength(50)]
        public string Drugs_VayofFeeding { get; set; }

        [StringLength(50)]
        public string Drugs_Others { get; set; }

        public bool? Drugs_ArtificialFormula { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreationTime { get; set; }

        public Guid? ModifyedBy { get; set; }

        public DateTime? ModificationTime { get; set; }

        [StringLength(50)]
        public string Examination_Respiratory_BR_After { get; set; }

        [StringLength(50)]
        public string Examination_Respiratory_O2Sat_After { get; set; }

        public short? Examination_Respiratory_Color_After { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        public virtual aspnet_Users aspnet_Users1 { get; set; }
    }
}

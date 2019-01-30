using PCHP.Core;
using PCHP.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PCHP.ViewModel
{
    public class ChildVm
    {
        public ChildViewModel Child { get; set; }
        public List<AddressVm> Addresses { get; set; }
        public List<PhoneVm> Phones { get; set; }
        public List<EmailVm> Emails { get; set; }
        public ChildDemographicViewModel ChildDemographic { get; set; }
        public List<ChildDemographicDetailViewModel> ChildDemographicDetails { get; set; }
        public List<ChildNativeLanguageViewModel> ChildNativeLanguages { get; set; }
        public List<ChildSiblingViewModel> ChildSiblings { get; set; }
        public ChildAdditionalInformationViewModel ChildAdditionalInformation { get; set; }
        public List<ChildAdultInformationViewModel> ChildAdultInformations { get; set; }
        public List<ChildInsuranceWellnessViewModel> ChildInsuranceWellness { get; set; }
        public List<ChildVisitViewModel> ChildVisit { get; set; }
        public List<ChildLiteracyActivitiesViewModel> ChildLiteracyActivities { get; set; }

        public bool IsAllStageCompleted { get; set; }
    }

    public class ChildAddUpdate
    {
        public ChildInformationLevel InformationLevel { get; set; }
        public int ChildId { get; set; }

        public ChildViewModel Child { get; set; }

        public List<AddressVm> Addresses { get; set; }
        public List<PhoneVm> Phones { get; set; }
        public List<EmailVm> Emails { get; set; }

        public ChildDemographicViewModel ChildDemographic { get; set; }
        public List<ChildDemographicDetailViewModel> ChildDemographicDetails { get; set; }
        public List<ChildNativeLanguageViewModel> ChildNativeLanguages { get; set; }

        public List<ChildSiblingViewModel> ChildSiblings { get; set; }

        public ChildAdditionalInformationViewModel ChildAdditionalInformation { get; set; }

        public List<ChildAdultInformationViewModel> ChildAdultInformations { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class ChildListFilterRequest : GridParameter
    {
        public string[] ChildNames { get; set; }
        public List<int> ChildIds { get; set; }
        public int ChildId { get; set; }
        public List<int> ElsIds { get; set; }
        public List<int> SiteIds { get; set; }
        public int? ProgramYearId { get; set; }
        public int? SiteId { get; set; }
        public int? ProgramStatus { get; set; }
        public ProgramCycle? ProgramCycle { get; set; }
        public bool? IsGraduated { get; set; }

        public List<UserRoleBridgeVM> UserRoles { get; set; }
    }

    public class ChildListResultVm : GridResultVm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public int SiteId { get; set; }
        public string SiteName { get; set; }

        public bool IsActive { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public DateTime IntakeDate { get; set; }
        public int ProgramYearId { get; set; }
        public string ProgramYearName { get; set; }
        public ProgramCycle ProgramCycle { get; set; }
        public DateTime? ProgramStartDate { get; set; }
        public DateTime? ProgramEndDate { get; set; }
        public int ElsId { get; set; }
        public string ElsFirstName { get; set; }
        public string ElsMiddleName { get; set; }
        public string ElsLastName { get; set; }
        public int ChildStatus { get; set; }
        public bool IsGraduated { get; set; }
        public string ProgramStatusName { get; set; }
        public int? IntakeAge { get; set; }
    }

    public class ChildViewModel
    {
        public int Id { get; set; }
        public int? SiteId { get; set; }
        public string SiteName { get; set; }
        public bool RequiredChildName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PlaceOfBirth { get; set; }
        public DateTime IntakeDate { get; set; }
        public string IntakeForm { get; set; }
        public string OriginalDocument { get; set; }
        public string IntakeFormExtension { get; set; }
        public int ProgramYearId { get; set; }
        public string ProgramYearName { get; set; }
        public ProgramCycle ProgramCycle { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
        public int ChildStatus { get; set; }
        public int? IntakeAge { get; set; }
    }

    public class ChildDemographicViewModel
    {
        public int Id { get; set; }
        public int ChildId { get; set; }

        public bool IsHispanic { get; set; }
        public bool HasPreviouslyRecievedEducation { get; set; }
        public bool IsCurrentlyRecievingEducation { get; set; }
        public bool HasPreviouslyRecievedVisiting { get; set; }
        public bool IsCurrentlyRecievingVisiting { get; set; }
        public bool HasHealthConditions { get; set; }
        public bool HasRecievedTreatment { get; set; }
        public int TreatmentRecievedFor { get; set; }
        public int TreatmentNotRecievedReason { get; set; }
        public bool DidMotherReceiveCareDuringPregnancy { get; set; }
        public bool DiagnosedWithSpecialNeed { get; set; }
        public bool IsReceivingSpecialNeedServices { get; set; }
        public int? EthinicityId { get; set; }
        public string EthinicityName { get; set; }
        public int? SubEthinicityId { get; set; }
        public string SubEthinicityName { get; set; }
        public int? PrimaryLanguageSpokenAtHome { get; set; }
        public int? PrimaryLanguageSpokenInHomeVisit { get; set; }
        public int? EnglishSkill { get; set; }
        public bool WasChildLowBirthWeight { get; set; }
        public bool WasChildBornPrematurely { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
        public int ChildNativeLanguage { get; set; }
    }

    public class ChildNativeLanguageViewModel
    {
        public int Id { get; set; }
        public int ChildId { get; set; }
        public int Language { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class ChildDemographicDetailViewModel
    {
        public int Id { get; set; }
        public int ChildId { get; set; }
        public int QuetionType { get; set; }
        public string Answer { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class ChildSiblingViewModel
    {
        public int Id { get; set; }
        public int ChildId { get; set; }

        public bool WillSiblingParticipateInVisit { get; set; }

        public bool? IsSiblingEligibleForFreeLunch { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public bool? IsParticipatedInPchp { get; set; }
        public string ReceiveSpecialEducationService { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
        public int? IntakeAge { get; set; }
    }

    public class ChildAdditionalInformationViewModel
    {
        public int Id { get; set; }
        public int ChildId { get; set; }

        public bool DidReceiveGovernmentAid { get; set; }
        public bool PlanToMoveDuringProgramCycle { get; set; }
        public int LivedAtCurrentResidence { get; set; }
        public int FamilyComposition { get; set; }
        public int FundingSource { get; set; }

        public int HowFamilyProgramLearning { get; set; }
        public string ReferralAgecyName { get; set; }
        public string ChildReceiveGovermentAid { get; set; }
        public bool IsFamilyHomeless { get; set; }
        public int AnnualFamilyIncomeRange { get; set; }
        public int TotalPeopleSupportedByIncome { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class ChildAdultInformationViewModel
    {
        public List<AddressVm> Addresses { get; set; }
        public List<ChildAdultNativeLanguageViewModel> NativeLanguages { get; set; }

        public int Id { get; set; }
        public int ChildId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RelationshipToChild { get; set; }
        public bool IsPrimaryCaregiver { get; set; }

        public int IndustryYouWorkIn { get; set; }
        public bool IsHispanic { get; set; }

        public bool IsParticipatingInHomeVisits { get; set; }
        public int LivesWithChild { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public bool IsBornInUs { get; set; }
        public int BornCountryId { get; set; }
        public string BornCountryName { get; set; }

        public int NumberOfYearsInUs { get; set; }

        public int EthinicityId { get; set; }
        public string EthinicityName { get; set; }
        public int SubEthinicityId { get; set; }
        public string SubEthinicityName { get; set; }

        public int? CanSpeakEnglish { get; set; }
        public int CanWriteEnglish { get; set; }
        public int CanReadEnglish { get; set; }
        public int? CanSpeakNativeLanguage { get; set; }
        public int CanWriteNativeLanguage { get; set; }
        public int? CanReadNativeLanguage { get; set; }
        public int EmploymentStatusId { get; set; }
        public bool HasAdultGraduatedHighSchoolOrReceiveGed { get; set; }
        public int NumberOfYearsSchoolingCompletedOutsideUs { get; set; }
        public int NumberOfYearsSchoolingCompletedInsideUs { get; set; }
        public bool IsAdultCurrentlyInSchoolOrEducationalProgram { get; set; }
        public int SchoolOrEducationalProgramType { get; set; }
        public bool WasThisAdult19YearsOldWhenThisChildWasBorn { get; set; }
        public bool IsSingleParent { get; set; }
        public int MaritalStatus { get; set; }
        public bool? HasServedInMilitary { get; set; }
        public string CoordinatorNotes { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
        public int NativeLanguagesAdult { get; set; }
        public int PrimaryCaregiverHours { get; set; }
        public int? IntakeAge { get; set; }

    }

    public class ChildAdultNativeLanguageViewModel
    {
        public int Id { get; set; }
        public int ChildAdultId { get; set; }
        public int Language { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    //Child Program Year Changes
    public class ChildProgramYearAddUpdate
    {
        public int Id { get; set; }
        public int? ChildId { get; set; }
        public int ProgramYearId { get; set; }
        public ProgramCycle? ProgramCycle { get; set; }
        public int VisitsSequence { get; set; }
        public DateTime? ProgramStartDate { get; set; }
        public DateTime? ProgramEndDate { get; set; }
        public int? ElsId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

        public int? ProviderId { get; set; }

    }

    public class ChildProgramYearViewModel
    {
        public int Id { get; set; }
        public int ChildId { get; set; }
        public int ProgramYearId { get; set; }
        public string ProgramYearName { get; set; }
        public ProgramCycle ProgramCycle { get; set; }
        public int VisitsSequence { get; set; }
        public DateTime? ProgramStartDate { get; set; }
        public DateTime? ProgramEndDate { get; set; }
        public int? ElsId { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class ChildProgramYearGridResult
    {
        public int Id { get; set; }
        public int? ChildId { get; set; }
        public int? ProviderId { get; set; }
        public int ProgramYearId { get; set; }
        public string ProgramYearName { get; set; }
        public string SiteName { get; set; }
        public ProgramCycle? ProgramCycle { get; set; }
        public int VisitsSequence { get; set; }
        public DateTime? ProgramStartDate { get; set; }
        public DateTime? ProgramEndDate { get; set; }
        public int? ElsId { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class ChildProgramYearBridgeListFilterRequest : GridParameter
    {
        public int? ChildId { get; set; }
        public int? ProviderId { get; set; }
        public int ProgramYearId { get; set; }
        public string ProgramYearName { get; set; }
        public ProgramCycle? ProgramCycle { get; set; }
        public int VisitsSequence { get; set; }
        public DateTime? ProgramStartDate { get; set; }
        public DateTime? ProgramEndDate { get; set; }
        public int? ElsId { get; set; }
    }
    //Child ELS Changes
    public class ChildProgramYearElsBridgeAddUpdate
    {
        public int Id { get; set; }
        public int ChildProgramYearBridgeId { get; set; }
        public int ElsId { get; set; }
        public DateTime ElsStartDate { get; set; }
        public DateTime? ElsEndDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class ChildProgramYearElsViewModel
    {
        public int Id { get; set; }
        public int ChildProgramYearBridgeId { get; set; }
        public int ElsId { get; set; }
        public string ElsName { get; set; }
        public string SiteName { get; set; }
        public string ProgramYearName { get; set; }
        public ProgramCycle ProgramCycle { get; set; }
        public int VisitsSequence { get; set; }
        public DateTime ElsStartDate { get; set; }
        public DateTime? ElsEndDate { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class ChildProgramYearElsGridResult
    {
        public int Id { get; set; }
        public int ChildProgramYearBridgeId { get; set; }
        public int ElsId { get; set; }
        public string ElsName { get; set; }
        public string SiteName { get; set; }
        public string ProgramYearName { get; set; }
        public ProgramCycle ProgramCycle { get; set; }
        public int VisitsSequence { get; set; }
        public DateTime ElsStartDate { get; set; }
        public DateTime? ElsEndDate { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class ChildProgramYearElsBridgeListFilterRequest : GridParameter
    {
        public int ChildProgramYearBridgeId { get; set; }
        public int ChildId { get; set; }
        public int ProviderId { get; set; }

        public int ElsId { get; set; }
        public DateTime? ElsStartDate { get; set; }
        public DateTime? ElsEndDate { get; set; }
    }
    
    //Child Insurance & Wellness 
    public class ChildInsuranceWellnessGridResult
    {
        public int Id { get; set; }
        public int ChildProgramYearBridgeId { get; set; }
        public string ProgramYearName { get; set; }
        public ProgramCycle ProgramCycle { get; set; }
        public int ChildId { get; set; }
        public DateTime? Date { get; set; }
        public ChildInsuranceType? ChildInsuranceType { get; set; }
        public PrimaryCaregiverContinuousHealthcare? PrimaryCaregiverContinuousHealthcare { get; set; }
        public FamilyMembersInsured? FamilyMembersInsured { get; set; }
        public ChildInsured? ChildInsured { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class ChildInsuranceWellnessViewModel
    {
        public int Id { get; set; }
        public int ChildProgramYearBridgeId { get; set; }
        public string ProgramYearName { get; set; }
        public ProgramCycle ProgramCycle { get; set; }
        public int ChildId { get; set; }
        public DateTime? Date { get; set; }
        public int? ChildInsuranceType { get; set; }
        public PrimaryCaregiverContinuousHealthcare? PrimaryCaregiverContinuousHealthcare { get; set; }
        public FamilyMembersInsured? FamilyMembersInsured { get; set; }
        public ChildInsured? ChildInsured { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class ChildInsuranceWellnessListFilterRequest : GridParameter
    {
        public int ChildId { get; set; }
    }
    
    //Child Visit
    public class ChildVisitGridResult
    {
        public int Id { get; set; }
        public int ChildProgramYearBridgeId { get; set; }
        public string ProgramYearName { get; set; }
        public ProgramCycle ProgramCycle { get; set; }
        public HadChildWellVisitMonth? HadChildWellVisitMonth { get; set; }
        public DateTime? Month { get; set; }
        public DateTime? VisitedDate { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class ChildVisitViewModel
    {
        public int Id { get; set; }
        public int ChildProgramYearBridgeId { get; set; }
        public string ProgramYearName { get; set; }
        public HadChildWellVisitMonth? HadChildWellVisitMonth { get; set; }
        public DateTime? Month { get; set; }
        public DateTime? VisitedDate { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class ChildVisitListFilterRequest : GridParameter
    {
        public int ChildId { get; set; }
    }

    //Child Literacy Activities
    public class ChildLiteracyActivitiesGridResult
    {
        public int Id { get; set; }
        public int ChildProgramYearBridgeId { get; set; }
        public ProgramCycle ProgramCycle { get; set; }
        public DateTime? ProgramStartDate { get; set; }
        public DateTime? ProgramEndDate { get; set; }
        public int? SurveyAnswer { get; set; }
        public DateTime? SurveyDate { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class ChildLiteracyActivitiesViewModel
    {
        public int Id { get; set; }
        public int ChildProgramYearBridgeId { get; set; }
        public ProgramCycle ProgramCycle { get; set; }
        public int? SurveyAnswer { get; set; }
        public DateTime? SurveyDate { get; set; }
        public DateTime? ProgramStartDate { get; set; }
        public DateTime? ProgramEndDate { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class ChildLiteracyActivitiesListFilterRequest : GridParameter
    {
        public int ChildId { get; set; }
    }


    public class ChildListExcelResultVm
    {
        [Description("Site Id")]
        public int SiteId { get; set; }
        //public string SiteName { get; set; }
        [Description("Child Id")]
        public int ChildId { get; set; }
        [Description("First Name")]
        public string FirstName { get; set; }
        [Description("Last Name")]
        public string LastName { get; set; }
        //public int? ChildStatusId { get; set; }
        [Description("Program Status")]
        public string ChildStatus { get; set; }
        [Description("Program Start")]
        public DateTime? ProgramStartDate { get; set; }
        [Description("Program End")]
        public DateTime? ProgramEndDate { get; set; }
        [Description("Home Visitor First Name")]
        public string HomeVisitorFirstName { get; set; }
        [Description("Home Visitor Last Name")]
        public string HomeVisitorLastName { get; set; }

        [Description("Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        public string Zip { get; set; }
        [Description("Race/Ethnicity")]
        public string EthinicityName { get; set; }
        //public int? NativeLanguageId { get; set; }
        [Description("Native Language")]
        public string NativeLanguage { get; set; }
        //public int? EnglishSkillId { get; set; }
        [Description("English Language Skills")]
        public string EnglishSkill { get; set; }
        //public int? PrimaryLanguageSpokenAtHomeId { get; set; }
        [Description("Primary Language Spoken at Home")]
        public string PrimaryLanguageSpokenAtHome { get; set; }
        //public int? PrimaryLanguageSpokenInHomeVisitId { get; set; }
        [Description("Primary Language in Home Visits")]
        public string PrimaryLanguageSpokenInHomeVisit { get; set; }

        [Description("Other Home Visiting Services Currently Receiving")]
        public bool IsCurrentlyRecievingVisiting { get; set; }
        [Description("Other Home Visiting Services Previously Received")]
        public bool HasPreviouslyRecievedVisiting { get; set; }
        [Description("Other ECES Services Currently In")]
        public bool IsCurrentlyRecievingEducation { get; set; }
        [Description("Other ECES Services Previously In")]
        public bool HasPreviouslyRecievedEducation { get; set; }


        [Description("Low Birth Weight")]
        public bool LowBirthWeight { get; set; }
        [Description("Born Prematurely")]
        public bool BornPrematurely { get; set; }

        [Description("Diagnosed w/Special Needs")]
        public bool DiagnosedWithSpecialNeed { get; set; }
        [Description("Receiving Special Need Services")]
        public bool IsReceivingSpecialNeedServices { get; set; }
        [Description("Family/Child Receives Govt Aid")]
        public bool DidReceiveGovernmentAid { get; set; }

        [Description("Is Family Homeless?")]
        public bool IsFamilyHomeless { get; set; }
        //public int? AnnualFamilyIncomeRange { get; set; }
        [Description("Family Income")]
        public string AnnualFamilyIncomeRangeValue { get; set; }

    }

    public class CbtExcelResultVm
    {
        [Description("Child Id")]
        public int? ChildId { get; set; }
        //public int? ChildStatusId { get; set; }
        [Description("Child Status")]
        public string ChildStatus { get; set; }
        [Description("Child's Name")]
        public string ChildName { get; set; }
        //public int? ElsId { get; set; }
        [Description("Home Visitor's Name")]
        public string ElsName { get; set; }
        [Description("Date")]
        public DateTime? EntryDate { get; set; }
        [Description("Program Year")]
        public string ProgramYearName { get; set; }
        //public int? ProgramCycle { get; set; }
        //public int? ParentCaregiverId { get; set; }
        [Description("Parent / Caregiver")]
        public string RelationshipToChildMasterValue { get; set; }

        public string Separator1 { get; set; }

        //public int? ChildCoreFormsDetailId { get; set; }
        public decimal? P1 { get; set; }
        public decimal? P2 { get; set; }
        public decimal? P3 { get; set; }
        public decimal? P4 { get; set; }
        public decimal? P5 { get; set; }
        public decimal? P6 { get; set; }
        public decimal? P7 { get; set; }
        public decimal? P8 { get; set; }
        public decimal? P9 { get; set; }
        public decimal? P10 { get; set; }
        public decimal? P11 { get; set; }
        public decimal? P12 { get; set; }
        public decimal? P13 { get; set; }
        public decimal? P14 { get; set; }
        public decimal? P15 { get; set; }
        public decimal? P16 { get; set; }
        public decimal? P17 { get; set; }
        public decimal? P18 { get; set; }
        public decimal? P19 { get; set; }
        public decimal? P20 { get; set; }

        public string Separator2 { get; set; }
        public decimal? P21 { get; set; }
        public decimal? P22 { get; set; }
        public decimal? P23 { get; set; }
        public decimal? P24 { get; set; }
        public decimal? P25 { get; set; }
        public decimal? P26 { get; set; }
        public decimal? P27 { get; set; }
        public decimal? P28 { get; set; }
        public decimal? P29 { get; set; }
        public decimal? P30 { get; set; }
        public decimal? P31 { get; set; }
        public decimal? P32 { get; set; }
        public decimal? P33 { get; set; }
        public decimal? P34 { get; set; }
        public decimal? P35 { get; set; }
        public decimal? P36 { get; set; }
        public decimal? P37 { get; set; }
        public decimal? P38 { get; set; }
        public decimal? P39 { get; set; }
        public decimal? P40 { get; set; }

        public string Separator3 { get; set; }
        public decimal? Q1 { get; set; }
        public decimal? Q2 { get; set; }
        public decimal? Q3 { get; set; }
        public decimal? Q4 { get; set; }
        public decimal? Q5 { get; set; }
        public decimal? Q6 { get; set; }
        public decimal? Q7 { get; set; }
        public decimal? Q8 { get; set; }
        public decimal? Q9 { get; set; }
        public decimal? Q10 { get; set; }
        public decimal? Q11 { get; set; }
        public decimal? Q12 { get; set; }
        public decimal? Q13 { get; set; }
        public decimal? Q14 { get; set; }
        public decimal? Q15 { get; set; }
        public decimal? Q16 { get; set; }
        public decimal? Q17 { get; set; }
        public decimal? Q18 { get; set; }
        public decimal? Q19 { get; set; }
        public decimal? Q20 { get; set; }

        public string Separator4 { get; set; }
        public decimal? Q21 { get; set; }
        public decimal? Q22 { get; set; }
        public decimal? Q23 { get; set; }
        public decimal? Q24 { get; set; }
        public decimal? Q25 { get; set; }
        public decimal? Q26 { get; set; }
        public decimal? Q27 { get; set; }
        public decimal? Q28 { get; set; }
        public decimal? Q29 { get; set; }
        public decimal? Q30 { get; set; }
        public decimal? Q31 { get; set; }
        public decimal? Q32 { get; set; }
        public decimal? Q33 { get; set; }
        public decimal? Q34 { get; set; }
        public decimal? Q35 { get; set; }
        public decimal? Q36 { get; set; }
        public decimal? Q37 { get; set; }
        public decimal? Q38 { get; set; }
        public decimal? Q39 { get; set; }
        public decimal? Q40 { get; set; }
        public string Separator5 { get; set; }

    }

    public class AdultCaregiverListExcelResultVm
    {
        [Description("Site Id")]
        public int SiteId { get; set; }
        //public string SiteName { get; set; }
        [Description("Child Id")] 
        public int ChildId { get; set; }
        //public int ParentOrCaregiverId { get; set; }
        
        [Description("Parent/Caregiver #1 First Name")]
        public string ParentOrCaregiverFirstName { get; set; }
        [Description("Parent/Caregiver #1 Last Name")]
        public string ParentOrCaregiverLastName { get; set; }
        [Description("Is Primary Caregiver")]
        public bool IsPrimaryCaregiver { get; set; }

        [Description("Is Participating in Home Visits")]
        public bool IsParticipatingInHomeVisits { get; set; }
        //public int RelationshipToChild { get; set; }
        [Description("Relationship to Child")]
        public string RelationshipToChildValue { get; set; }

        //public int LivesWithChild { get; set; }
        [Description("Lives With")]
        public string LivesWithChildValue { get; set; }
        //public DateTime? ChildAdultDateOfBirth { get; set; }
        [Description("Primary Caregiver #1 Age")]
        public int ChildAdultAge { get; set; }
        [Description("Primary Caregiver #1 Born in U.S.")]
        public bool IsBornInUs { get; set; }
        [Description("Primary Caregiver #1 Race/Ethnicity")]
        public string EthinicityName { get; set; }
        
        //public int? ChildAdultNativeLanguageId { get; set; }
        [Description("Primary Caregiver #1 Native Language")]
        public string ChildAdultNativeLanguageValue { get; set; }

        //public int EmploymentStatusId { get; set; }
        [Description("Primary Caregiver #1 Employment")]
        public string EmploymentStatusValue { get; set; }

        [Description("Primary Caregiver #1 HS Graduate")]
        public bool HasAdultGraduatedHighSchool { get; set; }
        [Description("Primary Caregiver #1 Current Schooling")]
        public bool IsAdultCurrentlyInSchoolOrEducationalProgram { get; set; }
        [Description("Primary Caregiver #1 Is Teen Parent")]
        public bool IsTeenParent { get; set; }
        [Description("Primary Caregiver #1 Is Single Parent")]
        public bool IsSingleParent { get; set; }
        //public int MaritalStatusId { get; set; }
        [Description("Primary Caregiver #1 Marital Status")]
        public string MaritalStatusValue { get; set; }

    }
}
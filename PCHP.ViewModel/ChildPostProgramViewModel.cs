using PCHP.Core.Enums;
using System;

namespace PCHP.ViewModel
{
    public class ChildPostProgramViewModel
    {
        public int Id { get; set; }

        public int ChildId { get; set; }

        public string ChildFirstName { get; set; }
        public string ChildMiddleName { get; set; }
        public string ChildLastName { get; set; }

        public string ElsId { get; set; }
        public string ElsName { get; set; }
 
        public string AdultFirstName { get; set; }
        public string AdultLastName { get; set; }

        public int? NoOfHomeVisitsOffered { get; set; }
        public int? NoOfHomeVisitsCompleted { get; set; }
        public int? NoOfBooksOffered { get; set; }
        public int? NoOfBooksReceived { get; set; }
        public int? NoOfToysOffered { get; set; }
        public int? NoOfToysReceived { get; set; }

        public int ChildProgramYearBridgeId { get; set; }
        public string Supervisor { get; set; }
        public DateTime LastVismDate { get; set; }
        public bool EarlyInventionRecommendedForEvaluation { get; set; }
        public bool EarlyInventionEvaluatedForEarlyIntervention { get; set; }
        public EarlyInventionEarlyInterventionServicesOffered EarlyInventionEarlyInterventionServicesOffered { get; set; }
        public int PrimaryCaregiverId { get; set; }
        public int PrimaryChildCareDurationByAdult { get; set; }
        public int PrimaryAdultEmploymentStatus { get; set; }
        public bool PrimaryIsChildInEducation { get; set; }
        public int PrimaryEducationType { get; set; }
        public string PrimaryOtherEducationType { get; set; }
        public int SecondaryCaregiverId { get; set; }
        public int SecondaryChildCareDurationByAdult { get; set; }
        public int SecondaryAdultEmploymentStatus { get; set; }
        public bool SecondaryIsChildInEducation { get; set; }
        public int SecondaryEducationType { get; set; }
        public string SecondaryOtherEducationType { get; set; }
        public bool IsFamilyHomeless { get; set; }
        public bool IsFamilyAccessingCommunityServices { get; set; }
        public int CommunityServicesType { get; set; }
        public string OtherCommunityServicesType { get; set; }
        public bool SiblingsParticipant { get; set; }
        public int NoOfSiblingsParticipant { get; set; }
        public bool OtherChildrenHouseholdParticipant { get; set; }
        public int NoOfOtherChildrenHouseholdParticipant { get; set; }
        public bool IsProgramOneCompleted { get; set; }
        public int ProgramOneNotCompletedReason { get; set; }
        public string ProgramOneNotCompletedReasonOther { get; set; }
        public bool IsProgramTwoReturning { get; set; }
        public int ProgramTwoNotReturningReason { get; set; }
        public string ProgramTwoNotReturningOtherReason { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime LastEditedOn { get; set; }
    }
    public class ChildPostProgramAdd
    {
        public int ChildProgramYearBridgeId { get; set; }
        public string Supervisor { get; set; }
        public DateTime LastVismDate { get; set; }

        public bool EarlyInventionRecommendedForEvaluation { get; set; }
        public bool EarlyInventionEvaluatedForEarlyIntervention { get; set; }
        public EarlyInventionEarlyInterventionServicesOffered EarlyInventionEarlyInterventionServicesOffered { get; set; }

        public int PrimaryCaregiverId { get; set; }
        public int PrimaryChildCareDurationByAdult { get; set; }
        public int PrimaryAdultEmploymentStatus { get; set; }
        public bool PrimaryIsChildInEducation { get; set; }
        public int PrimaryEducationType { get; set; }
        public string PrimaryOtherEducationType { get; set; }

        public int SecondaryCaregiverId { get; set; }
        public int SecondaryChildCareDurationByAdult { get; set; }
        public int SecondaryAdultEmploymentStatus { get; set; }
        public bool SecondaryIsChildInEducation { get; set; }
        public int SecondaryEducationType { get; set; }
        public string SecondaryOtherEducationType { get; set; }

        public bool IsFamilyHomeless { get; set; }
        public bool IsFamilyAccessingCommunityServices { get; set; }
        public int CommunityServicesType { get; set; }
        public string OtherCommunityServicesType { get; set; }

        public bool SiblingsParticipant { get; set; }
        public int NoOfSiblingsParticipant { get; set; }
        public bool OtherChildrenHouseholdParticipant { get; set; }
        public int NoOfOtherChildrenHouseholdParticipant { get; set; }

        public int? NoOfHomeVisitsOffered { get; set; }
        public int? NoOfHomeVisitsCompleted { get; set; }
        public int? NoOfBooksOffered { get; set; }
        public int? NoOfBooksReceived { get; set; }
        public int? NoOfToysOffered { get; set; }
        public int? NoOfToysReceived { get; set; }

        public bool IsProgramOneCompleted { get; set; }
        public int ProgramOneNotCompletedReason { get; set; }
        public string ProgramOneNotCompletedReasonOther { get; set; }

        public bool IsProgramTwoReturning { get; set; }
        public int ProgramTwoNotReturningReason { get; set; }
        public string ProgramTwoNotReturningOtherReason { get; set; }

        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime LastEditedOn { get; set; }
        public int ChildId { get; set; }
    }
}
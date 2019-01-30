using System;

namespace PCHP.ViewModel
{
    public class FccChildAddUpdate
    {
        public int Id { get; set; }

        public int ProviderId { get; set; }
        public int ProgramYearId { get; set; }
        public DateTime ProgramStartDate { get; set; }
        public DateTime? ProgramEndDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public bool ReceivingGovernmentAid { get; set; }
        public int NumberOfDays { get; set; }
        public string EnrolledInOtherPrograms { get; set; }
        public int ChildStatus { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

    }

    public class FccChildViewModel
    {
        public int Id { get; set; }

        public int SiteId { get; set; }
        public int ProviderId { get; set; }
        public int ProgramYearId { get; set; }
        public DateTime ProgramStartDate { get; set; }
        public DateTime? ProgramEndDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public bool ReceivingGovernmentAid { get; set; }
        public int NumberOfDays { get; set; }
        public string EnrolledInOtherPrograms { get; set; }
        public int ChildStatus { get; set; }

        public string ProviderFirstName { get; set; }
        public string ProviderLastName { get; set; }
        public string ProviderMiddleName { get; set; }
        public string SiteName { get; set; }
        public string ProgramYearName { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

    }

    public class FccChildGridResultVm : TGridResultViewModel
    {
        public int Id { get; set; }

        public int SiteId { get; set; }
        public int ProviderId { get; set; }
        public int ProgramYearId { get; set; }
        public DateTime ProgramStartDate { get; set; }
        public DateTime? ProgramEndDate { get; set; }
        public string ChildFirstName { get; set; }
        public string ChildLastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public bool ReceivingGovernmentAid { get; set; }
        public int NumberOfDays { get; set; }
        public string EnrolledInOtherPrograms { get; set; }
        public int ChildStatus { get; set; }

        public string ProviderFirstName { get; set; }
        public string ProviderLastName { get; set; }
        public string ProviderMiddleName { get; set; }
        public string SiteName { get; set; }
        public string ProgramYearName { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }
}
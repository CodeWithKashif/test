using PCHP.Core;
using System;
using System.Collections.Generic;

namespace PCHP.ViewModel
{
    public class ProviderStaffViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? Gender { get; set; }
        public string NativeLanguages { get; set; }
        public int EducationLevel { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
        public int Ethinicity { get; set; }
        public int SubEthinicity { get; set; }
        public List<ProviderStaffProgramYearBridgeViewModel> ProgramYearBridge { get; set; }

        public ProviderStaffViewModel()
        {
            ProgramYearBridge = new List<ProviderStaffProgramYearBridgeViewModel>();
        }
    }

    public class ProviderStaffAddUpdate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? Gender { get; set; }
        public string NativeLanguages { get; set; }
        public int EducationLevel { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
        public int Ethinicity { get; set; }
        public int SubEthinicity { get; set; }
        public List<ProviderStaffProgramYearBridgeViewModel> ProgramYearBridge { get; set; }

    }

    public class ProviderStaffListFilterRequest : GridParameter
    {
        public string[] ProviderStaffNames { get; set; }
        public string[] ProviderNames { get; set; }
        public int? ProgramYearId { get; set; }

        public int? ProviderId { get; set; }
        public int? SiteId { get; set; }
    }

    public class ProviderStaffListResultVm : TGridResultViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string SiteName { get; set; }
        public int? SiteId { get; set; }

        public int EducationLevelId { get; set; }
        public string EducationLevelName { get; set; }

        public string NativeLanguages { get; set; }
        public bool IsActive { get; set; }

        public int ProgramYearId { get; set; }
        public string ProgramYearName { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public int? ProviderId { get; set; }
        public string ProviderFirstName { get; set; }
        public string ProviderLastName { get; set; }
        public int Ethinicity { get; set; }
        public int SubEthinicity { get; set; }

    }
}

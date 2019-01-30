using PCHP.Core.Enums;
using System;

namespace PCHP.ViewModel
{
    public class ProviderViewModel
    {
        public int Id { get; set; }

        public int SiteId { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string ProgramYearName { get; set; }
        public int ProgramYearId { get; set; }
        public int VisitsSequence { get; set; }

        public int Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int InterviewedBy { get; set; }
        public LicenseStatus LicenseStatus { get; set; }
        public DateTime? LicenseDate { get; set; }
        public int YearsOfOperation { get; set; }
        public DateTime? IntakeDate { get; set; }
        public string IntakeForm { get; set; }
        public string OriginalDocument { get; set; }
        public string SiteName { get; set; }
        public bool IsActive { get; set; }
        public string RandomFileName { get; set; }
        public string InterviewedByFirstName { get; set; }
        public string InterviewedByMiddleName { get; set; }
        public string InterviewedByLastName { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }
}
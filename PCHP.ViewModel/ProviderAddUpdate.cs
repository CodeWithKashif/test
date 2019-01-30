using PCHP.Core.Enums;
using System;
using System.Collections.Generic;

namespace PCHP.ViewModel
{
    public class ProviderVm : ProviderViewModel
    {
        public List<AddressVm> Addresses { get; set; }
        public List<PhoneVm> Phones { get; set; }
        public List<EmailVm> Emails { get; set; }

        public ProviderVm()
        {
            Addresses = new List<AddressVm>();
            Phones = new List<PhoneVm>();
            Emails = new List<EmailVm>();
        }
    }

    public class ProviderAddUpdate
    {
        public int Id { get; set; }

        public int SiteId { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int InterviewedBy { get; set; }
        public LicenseStatus LicenseStatus { get; set; }
        public DateTime LicenseDate { get; set; }
        public int YearsOfOperation { get; set; }
        public DateTime IntakeDate { get; set; }

        public List<AddressVm> Addresses { get; set; }
        public List<PhoneVm> Phones { get; set; }
        public List<EmailVm> Emails { get; set; }

        public string IntakeForm { get; set; }
        public string OriginalDocument { get; set; }
        public string IntakeFormExtension { get; set; }

        public int ProgramYearId { get; set; }
        public int VisitsSequence { get; set; }

        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class ProviderGridResultVm : TGridResultViewModel
    {
        public int Id { get; set; }

        public int ElsId { get; set; }
        public int RegionId { get; set; }

        public int SiteId { get; set; }
        public int ProgramYearId { get; set; }

        public string RegionName { get; set; }
        public string SiteName { get; set; }
        public string ProgramYearName { get; set; }

        public DateTime? ProgramStartDate { get; set; }
        public DateTime? ProgramEndDate { get; set; }

        public string ElsFirstName { get; set; }
        public string ElsLastName { get; set; }

        public string ProviderFirstName { get; set; }
        public string ProviderMiddleName { get; set; }
        public string ProviderLastName { get; set; }


        public int TotalChild { get; set; }
        public int TotalStaff { get; set; }

        public int ProgramStatus { get; set; }
    }

}
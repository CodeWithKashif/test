using PCHP.Core;
using System;
using System.Collections.Generic;

namespace PCHP.ViewModel
{

    public class SiteAddUpdate
    {
        public List<AddressVm> Addresses { get; set; }
        public List<PhoneVm> Phones { get; set; }
        public List<EmailVm> Emails { get; set; }
        public List<SiteRegionBridgeVm> SiteRegions { get; set; }
        public List<SiteProgramsVm> SitePrograms { get; set; }
        public List<SiteSocialNetworkVm> SocialNetworks { get; set; }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string WebSite { get; set; }
        public bool IsVariation { get; set; }
        public string VariationDescription { get; set; }
        public bool IsRollingAdmissions { get; set; }
        public string RollingAdmissionDescription { get; set; }
        public bool RequiredChildName { get; set; }

        public bool IsActive { get; set; }
        
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class SiteCoordinatorAdd
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public int SiteId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public List<PhoneVm> Phones { get; set; }
        public List<EmailVm> Emails { get; set; }
    }


    public class SiteListFilterRequest : GridParameter
    {
        public string Name { get; set; }
        public int? ProgramId { get; set; }
        public int? RegionId { get; set; }
        public int? CountryId { get; set; }
        public string State { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsVariation { get; set; }
        public bool? IsRollingAdmissions { get; set; }
        public List<int> SiteIds { get; set; }
    }


    public class SiteGridResultVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string State { get; set; }
        public bool IsActive { get; set; }
        public bool RequiredChildName { get; set; }
        public bool IsVariation { get; set; }
        public string VariationDescription { get; set; }
        public bool IsRollingAdmissions { get; set; }
        public string RollingAdmissionDescription { get; set; }
        public string Regions { get; set; }
        public string Programs { get; set; }

        public SiteGridResultVm()
        {
            
        }
    }

    public class SiteViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string WebSite { get; set; }
        public bool IsVariation { get; set; }
        public string VariationDescription { get; set; }
        public bool IsRollingAdmissions { get; set; }
        public string RollingAdmissionDescription { get; set; }

        public bool RequiredChildName { get; set; }

        public bool IsActive { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

        public string CreatedByFirstName { get; set; }
        public string CreatedByMiddleName { get; set; }
        public string CreatedByLastName { get; set; }
        public string LastEditedByFirstName { get; set; }
        public string LastEditedByMiddleName { get; set; }
        public string LastEditedByLastName { get; set; }

        public List<AddressVm> Addresses { get; set; }
        public List<PhoneVm> Phones { get; set; }
        public List<EmailVm> Emails { get; set; }
        public List<SiteRegionBridgeVm> SiteRegions { get; set; }
        public List<SiteProgramsVm> SitePrograms { get; set; }
        public List<SiteSocialNetworkVm> SocialNetworks { get; set; }
        public List<SiteCoordinatorVm> SiteCoordinators { get; set; }

        public SiteViewModel()
        {
            Addresses=new List<AddressVm>();
            Phones = new List<PhoneVm>();
            Emails = new List<EmailVm>();
            SiteRegions = new List<SiteRegionBridgeVm>();
            SitePrograms = new List<SiteProgramsVm>();
            SocialNetworks = new List<SiteSocialNetworkVm>();
            SiteCoordinators = new List<SiteCoordinatorVm>();
        }
    }

    public class SiteCoordinatorVm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<PhoneVm> Phones { get; set; }
        public List<EmailVm> Emails { get; set; }
    }

    //public class SiteListStaffFilterVm : GridParameter
    //{
    //    public int SiteId { get; set; }
    //}

}
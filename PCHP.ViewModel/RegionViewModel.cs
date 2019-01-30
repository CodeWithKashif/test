using PCHP.Core;
using System;
using System.Collections.Generic;

namespace PCHP.ViewModel
{
    public class RegionAddressVm 
    {
        public int Id { get; set; }

        public int RegionId { get; set; }
        public string State { get; set; }
    
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class RegionAddUpdate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<RegionAddressVm> RegionAddresses { get; set; }

        public bool IsActive { get; set; }
        
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class RegionListFilterRequest : GridParameter
    {
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public int? CountryId { get; set; }
        public string State { get; set; }
    }


    public class RegionGridResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string State { get; set; }
        public bool IsActive { get; set; }
    }
    
    public class RegionViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public List<RegionAddressVm> RegionAddresses { get; set; }
        public List<RegionSiteDetailVm> RegionSites { get; set; }

        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public int CreatedBy { get; set; }
        public int? LastEditedBy { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime? LastEditedOn { get; set; }

        public string CreatedByFirstName { get; set; }
        public string CreatedByMiddleName { get; set; }
        public string CreatedByLastName { get; set; }
        public string LastEditedByFirstName { get; set; }
        public string LastEditedByMiddleName { get; set; }
        public string LastEditedByLastName { get; set; }

        public RegionViewModel()
        {
            RegionAddresses = new List<RegionAddressVm>();
        }
    }
}
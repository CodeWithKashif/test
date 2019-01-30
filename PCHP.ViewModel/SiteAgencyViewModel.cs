using PCHP.Core.Enums;
using System;
using System.Collections.Generic;

namespace PCHP.ViewModel
{
    public class SiteAgencyViewModel
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }

        public List<AddressVm> Addresses { get; set; }
        public List<PhoneVm> Phones { get; set; }

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

        public SiteAgencyViewModel()
        {
            Addresses = new List<AddressVm>();
            Phones = new List<PhoneVm>();
        }
    }

    public class SiteAgencyAddUpdate
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

        public List<AddressVm> Addresses { get; set; }
        public List<PhoneVm> Phones { get; set; }
    }

    public class SiteAgencyGridResultVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public AddressType AddressType { get; set; }
        public bool IsPrimaryAddress { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string State { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string County { get; set; }
        public string OtherGeographichInfo { get; set; }

        public PhoneType PhoneType { get; set; }
        public string PhoneNumber { get; set; }
    }

}
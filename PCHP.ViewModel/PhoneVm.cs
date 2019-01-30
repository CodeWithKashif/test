using PCHP.Core.Enums;

namespace PCHP.ViewModel
{
    public class PhoneVm
    {
        public int Id { get; set; }
        public int? ProviderId { get; set; }
        public int? SiteId { get; set; }
        public int? UserId { get; set; }
        public int? SiteAgencyId { get; set; }
        public int? SiteAgencyContactId { get; set; }
        public int? ChildId { get; set; }
        public int PhoneType { get; set; } 
        public string CountryCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Extension { get; set; }
        public bool IsActive { get; set; } 
        public bool IsPrimaryPhone { get; set; }

    }
}
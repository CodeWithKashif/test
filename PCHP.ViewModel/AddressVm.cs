using PCHP.Core.Enums;

namespace PCHP.ViewModel
{
    public class AddressVm
    {
        public int Id { get; set; }
        public int? ProviderId { get; set; }
        public int? UserId { get; set; }
        public int? SiteId { get; set; }
        public int? SiteAgencyId { get; set; }
        public int? ChildId { get; set; }
        public int? ChildAdultId { get; set; }
        public bool IsPrimaryAddress { get; set; }
        public int AddressType { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string State{ get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string County { get; set; }
        public string OtherGeographichInfo { get; set; }
        public bool IsActive { get; set; }

        //public int? UserId { get; set; }
    }
}
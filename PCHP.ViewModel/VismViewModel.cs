using PCHP.Core;
using PCHP.Core.Enums;
using System;

namespace PCHP.ViewModel
{
    public class VismAddUpdate
    {
        public int Id { get; set; }
        public VismType Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ToysManufacturer { get; set; }
        public string BookPublisher { get; set; }
        public string BookAuthor { get; set; }
        public decimal Price { get; set; }
        public int AgeRangeStart { get; set; }
        public int AgeRangeEnd { get; set; }
        public int SiteId { get; set; }
        public bool? IsActive { get; set; }
        public ApprovalLevel NcApprovalLevel { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class VismListFilterRequest : GridParameter
    {
        public VismType? Type { get; set; }
        public string Name { get; set; }
        public int SiteId { get; set; }
        public bool? IsSiteLevelVism { get; set; } //VISM List -- filter
        public ApprovalLevel? NcApprovalLevel { get; set; }
        public bool? IsActive { get; set; }
        public string ToysManufacturerOrPublisher { get; set; }
        public string BookAuthor { get; set; }
        public int AgeRangeStart { get; set; }
        public int AgeRangeEnd { get; set; }
        public string BookPublisher { get; set; }
        public bool IsNationalCentreLevel { get; set; }
        public string ToysManufacturer { get; set; }
    }


    public class VismGridResult
    {
        public int Id { get; set; }
        public VismType Type { get; set; }
        public string Name { get; set; }
        public string ToysManufacturer { get; set; }
        public string BookPublisher { get; set; }
        public string BookAuthor { get; set; }
        public decimal Price { get; set; }
        public int AgeRangeStart { get; set; }
        public int AgeRangeEnd { get; set; }
        public int SiteId { get; set; }
        public bool IsSiteLevelVism { get; set; } //VISM List
        public string SiteName { get; set; }
        public bool? IsActive { get; set; }
        public ApprovalLevel NcApprovalLevel { get; set; }

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
    }

    
    public class VismViewModel
    {
        public int Id { get; set; }
        public VismType Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ToysManufacturer { get; set; }
        public string BookPublisher { get; set; }
        public string BookAuthor { get; set; }
        public decimal Price { get; set; }
        public int AgeRangeStart { get; set; }
        public int AgeRangeEnd { get; set; }
        public int SiteId { get; set; }
        public string SiteName { get; set; }
        public ApprovalLevel NcApprovalLevel { get; set; }

        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
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
    }
}
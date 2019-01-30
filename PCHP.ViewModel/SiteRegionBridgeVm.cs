using System;

namespace PCHP.ViewModel
{
    public class SiteRegionBridgeVm
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }
}
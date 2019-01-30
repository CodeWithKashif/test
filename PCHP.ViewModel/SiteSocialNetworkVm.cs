using System;
using PCHP.Core.Enums;

namespace PCHP.ViewModel
{
    public class SiteSocialNetworkVm
    {
        public int Id { get; set; }

        public int SiteId { get; set; }
        public SocialNetworkType SocialNetworkType { get; set; }
        public string SocialHandle { get; set; }

        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

    }
}
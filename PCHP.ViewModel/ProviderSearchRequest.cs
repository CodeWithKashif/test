using PCHP.Core;
using System.Collections.Generic;

namespace PCHP.ViewModel
{
    public class ProviderSearchRequest : GridParameter
    {
        public string[] ElsNames { get; set; }
        public string[] ProviderNames { get; set; }

        public int? ElsId { get; set; }
        public int? ProviderId { get; set; }

        public List<int> SiteIds { get; set; }
        public int? RegionId { get; set; }
        public int? ProgramYearId { get; set; }

        public int? ProgramStatus { get; set; }
    }
}
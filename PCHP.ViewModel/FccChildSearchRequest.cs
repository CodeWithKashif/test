using PCHP.Core;
using System.Collections.Generic;

namespace PCHP.ViewModel
{
    public class FccChildSearchRequest : GridParameter
    {
        public string[] ChildNames { get; set; }
        public string[] ProviderNames { get; set; }

        public int? ChildId { get; set; }
        public int? ProviderId { get; set; }

        public List<int> SiteIds { get; set; }
        public int? ProgramYearId { get; set; }
        public int? ChildStatus { get; set; }
    }
}
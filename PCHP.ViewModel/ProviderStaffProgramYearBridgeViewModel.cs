using System;

namespace PCHP.ViewModel
{
    public class ProviderStaffProgramYearBridgeViewModel
    {
        public int Id { get; set; }

        public int ProviderStaffId { get; set; }

        public int ProviderId { get; set; }
        public string ProviderFirstName { get; set; }
        public string ProviderLastName { get; set; }

        public int ProviderSiteId { get; set; }
        public string ProviderSiteName { get; set; }

        public int ProgramYearId { get; set; }
        public string ProgramYearName { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string DaysAtSite { get; set; }
        public int HoursAtSite { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }
}
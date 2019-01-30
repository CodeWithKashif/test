using System;
using PCHP.Core;
using PCHP.Core.Enums;

namespace PCHP.ViewModel
{
    public class SiteOutreachViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SiteId { get; set; }
        public DateTime OutreachDate { get; set; }
        public ProgramType ProgramType { get; set; }
        public int LocationType { get; set; }
        public int InteractedFamiliesOrProviders { get; set; }
        public int PotentialFamiliesOrProviders { get; set; }
        public int FamilyOrProviderIntake { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class SiteOutreachListFilterRequest : GridParameter
    {
        public int SiteId { get; set; }
    }

    public class SiteOutreachGridResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SiteId { get; set; }
        public DateTime OutreachDate { get; set; }
        public ProgramType ProgramType { get; set; }
        public OutreachLocationType LocationType { get; set; }
        public int InteractedFamiliesOrProviders { get; set; }
        public int PotentialFamiliesOrProviders { get; set; }
        public int FamilyOrProviderIntake { get; set; }
        public string Description { get; set; }
    }

    public class SiteOutreachAddUpdate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SiteId { get; set; }
        public DateTime OutreachDate { get; set; }
        public ProgramType ProgramType { get; set; }
        public int LocationType { get; set; }
        public int InteractedFamiliesOrProviders { get; set; }
        public int PotentialFamiliesOrProviders { get; set; }
        public int FamilyOrProviderIntake { get; set; }
        public string Description { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

}
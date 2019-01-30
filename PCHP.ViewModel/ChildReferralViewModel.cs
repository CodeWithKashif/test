using PCHP.Core;
using PCHP.Core.Enums;
using System;
using System.Collections.Generic;

namespace PCHP.ViewModel
{
    public class ChildReferralViewModel
    {
        public int Id { get; set; }

        public int? ChildId { get; set; }
        public string ChildFirstName { get; set; }
        public string ChildMiddleName { get; set; }
        public string ChildLastName { get; set; }

        public int? ProviderId { get; set; }
        public string ProviderFirstName { get; set; }
        public string ProviderMiddleName { get; set; }
        public string ProviderLastName { get; set; }

        public int ProgramYearId { get; set; }
        public string ProgramYearName { get; set; }

        public ProgramType ProgramType { get; set; }
        
        public int ReferredToRoleId { get; set; }
        public int ReferredByRoleId { get; set; }
        public string ReferralAgency { get; set; }
        public DateTime NextContactDate { get; set; }
        public DateTime ReferredDate { get; set; }
        public string ReferralIds { get; set; }
        public string ReferralDescription { get; set; }
        public string Comments { get; set; }

        public List<ChildReferralStatusLogViewModel> ChildReferralStatusLogs { get; set; }

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

    public class ChildReferralAddUpdate
    {
        public int Id { get; set; }

        public int ChildId { get; set; }
        public int ProgramYearId { get; set; }
        public string ProgramYearName { get; set; }
        //public ProgramType ProgramType { get; set; }
        public ProgramType ProgramType => ChildId != null && ChildId > 0 ? ProgramType.Core : ProgramType.Fcc;

        public int ProviderId { get; set; }
        public int ReferredToRoleId { get; set; }
        public int ReferredByRoleId { get; set; }
        public string ReferralAgency { get; set; }
        public DateTime NextContactDate { get; set; }
        public DateTime ReferredDate { get; set; }
        public string ReferralIds { get; set; }
        public string ReferralDescription { get; set; }
        public string Comments { get; set; }

        public List<ChildReferralStatusLogViewModel> ChildReferralStatusLogs { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

    }

    public class ChildReferralGridResultViewModel:TGridResultViewModel
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string SiteName { get; set; }

        public string Regions { get; set; }

        public int? ChildId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public int? ProviderId { get; set; }
    
        public int ReferredToRoleId { get; set; }
        public ProgramType ProgramType => ChildId != null && ChildId > 0 ? ProgramType.Core : ProgramType.Fcc;

        public int ProgramYearId { get; set; }
        public string ProgramYearName { get; set; }
        public string ReferralIds { get; set; }
        public int ReferralStatus { get; set; }
        public DateTime NextContactDate { get; set; }
        public string ReferralAgency { get; set; }
        public int ReferredByRoleId { get; set; }
        public DateTime ReferredOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }

    public class ChildReferralFilterViewModel : GridParameter
    {
        public string[] ChildNames { get; set; }
        public string[] ProviderNames { get; set; }

        public int? ChildId { get; set; }
        public int? ProviderId { get; set; }
        public int? RegionId { get; set; }

        public int? ReferralStatus { get; set; }
        public string ReferralId { get; set; }
        public int? SiteId { get; set; }
        public ProgramType? ProgramType { get; set; }
        public int? ProgramYearId { get; set; }
    }

}
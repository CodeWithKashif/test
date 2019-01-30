using PCHP.Core;
using System;
using System.Collections.Generic;

namespace PCHP.ViewModel
{
    public class ProviderFormsSearchRequest : GridParameter
    {
        public int? ProviderId { get; set; }
        public int? SiteId { get; set; }
        public List<int> SiteIds { get; set; }
        public string[] ProviderNames { get; set; }
        public int? ProgramYearId { get; set; }
        public int? SurveyType { get; set; }
        public int? FormStatus { get; set; }
        public int? ProviderFormTypeId { get; set; }
    }

    public class ProviderFormsGridResultVm : TGridResultViewModel
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public int SiteId { get; set; }
        public string ProviderFirstName { get; set; }
        public string ProviderMiddleName { get; set; }
        public string ProviderLastName { get; set; }
        public string SiteName { get; set; }
        public string ProgramYearName { get; set; }
        public int ProgramYearId { get; set; }
        public int SurveyType { get; set; }
        public DateTime? SurveyDate { get; set; }
        public int? FormStatus { get; set; }
        public int NoOfParentSurvey { get; set; }

        public string FormName { get; set; }
        public string SurveyName { get; set; }
        public string FormStatusText { get; set; }

        public int ProviderFormTypeId { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

        public int ElsId { get; set; }
        public string ElsFirstName { get; set; }
        public string ElsMiddleName { get; set; }
        public string ElsLastName { get; set; }
    }
}
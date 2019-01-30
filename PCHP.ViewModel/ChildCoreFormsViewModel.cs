using PCHP.Core;
using PCHP.Core.Enums;
using System.Collections.Generic;

namespace PCHP.ViewModel
{
    public class ChildCoreFormsViewModel
    {
    }
    public class ChildCoreFormsGridResult : GridResultVm
    {
        public int Id { get; set; }
        public string ProgramYearName { get; set; }
        public ProgramCycle ProgramCycle { get; set; }

        public int ChildId { get; set; }
        public int ProviderId { get; set; }

        public Form Form { get; set; }
        public FormType FormType { get; set; }
        public FormStatus? FormStatus { get; set; }

        public AssessmentFormType? AssessmentFormType { get; set; }
        public int? MonthScale { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SiteName { get; set; }
        public int? ChildProgramYearBridgeId { get; set; }
    }

    public class ChildCoreFormsFilterRequest : GridParameter
    {
        public List<int> SiteIds { get; set; }
        public int? ProgramYearId { get; set; }
        public ProgramCycle? ProgramCycle { get; set; }
        public FormStatus? FormStatus { get; set; }

        public Form? Form { get; set; }
        public FormType? FormType { get; set; }

        public string[] ChildNames { get; set; }
        public string[] ProviderNames { get; set; }

        public int? ChildId { get; set; }
        public int? ProviderId { get; set; }
        public int? ChildProgramYearId { get; set; }

    }
}
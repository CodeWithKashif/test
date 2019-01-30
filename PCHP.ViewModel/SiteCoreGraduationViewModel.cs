using PCHP.Core;
using PCHP.Core.Enums;
using System;

namespace PCHP.ViewModel
{
    public class SiteCoreGraduationViewModel
    {
        public int Id { get; set; }

        public int SiteId { get; set; }
        public int ProgramYearId { get; set; }
        public ProgramCycle ProgramCycle { get; set; }
        public DateTime GradutionDate { get; set; }
        public string Comments { get; set; }

        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime LastEditedOn { get; set; }

        public string SiteName { get; set; }
        public string ProgramYearName { get; set; }
    }

    public class SiteCoreGraduationAddUpdate
    {
        public int Id { get; set; }

        public int SiteId { get; set; }
        public int ProgramYearId { get; set; }
        public ProgramCycle ProgramCycle { get; set; }
        public DateTime GradutionDate { get; set; }
        public string Comments { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime LastEditedOn { get; set; }
    }

    public class SiteCoreGraduationGridResultVm : TGridResultViewModel
    {
        public int Id { get; set; }

        public int SiteId { get; set; }
        public int ProgramYearId { get; set; }
        public ProgramCycle ProgramCycle { get; set; }
        public DateTime GradutionDate { get; set; }
        public string Comments { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

        public string ProgramYearName { get; set; }

    }

    public class SiteCoreGraduationFilterVm : GridParameter
    {
        public int SiteId { get; set; }
        public ProgramType ProgramType { get; set; }
    }
}

using System.Collections.Generic;
using PCHP.Core.Enums;

namespace PCHP.ViewModel
{
    public class ExcelExportFilterVm
    {
        public int? SiteId { get; set; }
        public List<int> SiteIds { get; set; }
        public int? RegionId { get; set; }
        public List<int> ChildIds { get; set; }
        public string[] ChildNames { get; set; }
        public int? ProgramYearId { get; set; }
        public ProgramCycle? ProgramCycle { get; set; }
        public ChildProgramStatus? ChildProgramStatus { get; set; }
    }
}
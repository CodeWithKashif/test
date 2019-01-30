using System.Collections.Generic;

namespace PCHP.ViewModel
{
    public class ProviderInfoVm
    {
        public ProviderFormsViewModel Provider { get; set; }

        public List<ProgramYearVm> ProgramYear { get; set; }

        public ProviderInfoVm()
        {
            ProgramYear = new List<ProgramYearVm>();
        }
    }

    public class ProgramYearVm : ProviderVisitAndVism
    {
        public int ProgramYearId { get; set; }
        public string ProgramYearName { get; set; }
        public int ChildProgramYearBridgeId { get; set; }

        public List<ElsVm> ElsList { get; set; }

        public ProgramYearVm()
        {
            ElsList = new List<ElsVm>();
        }
    }

    public class ProviderVisitAndVism
    {
        public int? VisitComplteteCount { get; set; }
        public int? TotalVismOfProvider { get; set; }
    }
    public class ElsVm
    {
        public int ElsId { get; set; }
        public string ElsFirstName { get; set; }
        public string ElsMiddleName { get; set; }
        public string ElsLastName { get; set; }
    }
}
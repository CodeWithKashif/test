using PCHP.Core.Enums;
using System;
using System.Collections.Generic;

namespace PCHP.ViewModel
{
    public class ElsScheduleManagmentGridResult
    {
        public int Id { get; set; }

        public string SiteName { get; set; }

        public int ChildId { get; set; }
        public int ProviderId { get; set; }
        public int ChildElsScheduleId { get; set; }

        public string ChildFirstName { get; set; }
        public string ChildMiddleName { get; set; }
        public string ChildLastName { get; set; }

        public string ProviderFirstName { get; set; }
        public string ProviderMiddleName { get; set; }
        public string ProviderLastName { get; set; }

        public int ProgramSequence { get; set; }
        public int Sequence { get; set; }

        public string ProgramYearName { get; set; }

        public ProgramCycle ProgramCycle { get; set; }
        public int SessionWeek { get; set; }
        public int Visit { get; set; }
        public DateTime? SessionDate { get; set; }
        public int? SessionTime { get; set; }
        public ChildVisitObservationStatus? Status { get; set; }
        public int? TimeLength { get; set; }

        public string ElsFirstName { get; set; }
        public string ElsMiddleName { get; set; }
        public string ElsLastName { get; set; }

        public string VismName { get; set; }
        public int? VismId { get; set; }
        public int? ElsId { get; set; }
    }

    public class ElsScheduleManagmentFilterRequest
    {
        public List<int> SiteIds { get; set; }
        public int? ProgramYearId { get; set; }
        public ProgramCycle? ProgramCycle { get; set; }
        public int? VismId { get; set; }
        public int? ElsId { get; set; }

        public string[] ChildNames { get; set; }
        public string[] ProviderNames { get; set; }

        public ChildVisitObservationStatus? Status { get; set; }
        public ProgramType ProgramType { get; set; }

    }
}
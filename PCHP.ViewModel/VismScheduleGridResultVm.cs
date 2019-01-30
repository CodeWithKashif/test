using System;
using System.Collections.Generic;
using PCHP.Core;
using PCHP.Core.Enums;

namespace PCHP.ViewModel
{
    public class VismScheduleViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SiteId { get; set; }
        public string SiteName { get; set; }
        public ProgramType ProgramType { get; set; }

        public int ProgramYearId { get; set; }
        public string ProgramYearName { get; set; }

        public ProgramCycle ProgramCycle { get; set; }
        public int Sequence { get; set; }

        public bool IsActive { get; set; }

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

        public List<VismScheduleDetailViewModel> ScheduleDetails { get; set; }

        
        public VismScheduleViewModel()
        {
            ScheduleDetails = new List<VismScheduleDetailViewModel>();
        }
    }

    public class VismScheduleAddUpdate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SiteId { get; set; }
        public ProgramType ProgramType { get; set; }
        public int ProgramYearId { get; set; }
        public ProgramCycle ProgramCycle { get; set; }
        public int Sequence { get; set; }
        public bool IsActive { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

        public List<VismScheduleDetailViewModel> ScheduleDetails { get; set; }

        public VismScheduleAddUpdate()
        {
            ScheduleDetails = new List<VismScheduleDetailViewModel>();
        }
    }

    public class VismScheduleGridResultVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProgramType ProgramType { get; set; }
        public int ProgramYearId { get; set; }
        public string ProgramYearName { get; set; }
        public ProgramCycle ProgramCycle { get; set; }
        public int MinimumNumberOfSession { get; set; }
        public int Sequence { get; set; }
        public int MinimumVisms{ get; set; }
        public int VismScheduled { get; set; }

        public bool IsActive { get; set; }

        public VismScheduleGridResultVm()
        {

        }
    }

    public class VismScheduleFilterRequest : GridParameter
    {
        public int? SiteId { get; set; }
        public string ScheduleName { get; set; }
        public ProgramType? ProgramType { get; set; }
        public int? ProgramYearId { get; set; }
        public ProgramCycle? ProgramCycle { get; set; }
        public int? Sequence { get; set; }
        public bool? IsActive { get; set; }
    }
}
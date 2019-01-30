using PCHP.Core.Enums;
using System;

namespace PCHP.ViewModel
{
    public class ChildElsScheduleDetailVm
    {
        public int Id { get; set; }
        public int ChildElsScheduleId { get; set; }
        public int ProgramSequence { get; set; } //Program year Sequence
        public int SessionWeek { get; set; }
        public DateTime? SessionDate { get; set; }
        public int? SessionTime { get; set; }
        public int Visit { get; set; }
        public int Sequence { get; set; }
        public int VismId { get; set; }
        public ChildVisitObservationStatus Status { get; set; }
        public int? TimeLength { get; set; }
        public string Reason { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }
}

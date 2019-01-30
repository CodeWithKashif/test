using PCHP.Core;
using PCHP.Core.Enums;
using System;
using System.Collections.Generic;

namespace PCHP.ViewModel
{
    public class ChildElsScheduleAddUpdate
    {
        public int Id { get; set; }
        public int ChildProgramYearBridgeId { get; set; }
        public string ScheduleName { get; set; }
        public string Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class ChildElsScheduleViewModel
    {
        public int Id { get; set; }
        public int ChildProgramYearBridgeId { get; set; }
        public string ScheduleName { get; set; }
        public string SiteName { get; set; }
        public string Status { get; set; }

        public int? CompletedSessions { get; set; }
        public int? PendingSessions { get; set; }
        public int TotalSessions { get; set; }

        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

        public int ChildElsScheduleId { get; set; }
        public int? ScheduleId { get; set; }
        public DateTime? SessionDate { get; set; }
        public DateTime? SessionTime { get; set; }
        public int? SessionWeek { get; set; }
        public int? Visit { get; set; }
        public int? Sequence { get; set; }
        public int? VismId { get; set; }


        public string ElsName { get; set; }
        public int? ProgramType { get; set; }
        public int? MidRangeStartNumber { get; set; }
        public int? MidRangeEndNumber { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }



        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

    }

    public class ChildElsScheduleFilterRequest : GridParameter
    {
        public int? ChildId { get; set; }
        public int? ProviderId { get; set; }
    }

    public class ChildElsScheduleGridResult : TGridResultViewModel
    {
        public int Id { get; set; }
        public int ProgramSequence { get; set; }

        public string SiteName { get; set; }

        public string ProgramYearName { get; set; }
        public int ProgramYearId { get; set; }

        public string ScheduleName { get; set; }

        /// <summary>
        /// Here ScheduleId is VismScheduleId(VismSchedule.Id)
        /// </summary>
        public int? ScheduleId { get; set; }

        public string Status { get; set; }

        public int? ElsId { get; set; }
        public int? MidRangeStartNumber { get; set; }
        public int? MidRangeEndNumber { get; set; }
        public int CompletedSessions { get; set; }
        public int PendingSessions { get; set; }
        public int TotalSessions { get; set; }
    }

    public class ChildAvailableScheduleListVm
    {
        public int Key { get; set; }
        public string Value { get; set; }
        public int Sequence { get; set; }
    }


    public class ChildElsScheduleDetailAdd
    {
        public List<ChildElsScheduleDetailVm> ChildElsScheduleDetail { get; set; }


        public int ScheduleId { get; set; }
        public int Id { get; set; }
        public int CreatedBy { get; set; }

        public ChildElsScheduleDetailAdd()
        {
            ChildElsScheduleDetail = new List<ChildElsScheduleDetailVm>();
        }
    }

    public class ChildElsScheduleDetailGridResult
    {
        public int Id { get; set; }
        public int ChildElsScheduleId { get; set; }
        public int SessionWeek { get; set; }
        public DateTime? SessionDate { get; set; }
        public int? SessionTime { get; set; }
        public int Visit { get; set; }
        public int Sequence { get; set; }
        public int VismId { get; set; }
        public string VismName { get; set; }
        public string Status { get; set; }
        public int? TimeLength { get; set; }
        public string Reason { get; set; }
        public int ProgramSequence { get; set; }

        public int ElsId { get; set; }
        public string ElsFirstName { get; set; }
        public string ElsMiddleName { get; set; }
        public string ElsLastName { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }
    
    public class ChildScheduleObservationAddUpdate
    {
        public int Id { get; set; }
        public int ChildElsScheduleDetailId { get; set; }

        public DateTime ReScheduleDate { get; set; }
        public int ReScheduleTime { get; set; }

        public int AdultId { get; set; }
        public string ElseOther { get; set; }
        public string AditionalActivites { get; set; }
        public string QueI { get; set; }
        public string QueII { get; set; }
        public string QueIII { get; set; }
        public string QueIV { get; set; }
        public string QueV { get; set; }
        public string QueVI { get; set; }
        public string QueVII { get; set; }
        public string QueVIIIa { get; set; }
        public string QueVIIIb { get; set; }
        public string QueIXa { get; set; }
        public string QueIXb { get; set; }
        public string QueX { get; set; }
        public string QueXI { get; set; }
        public string QueXII { get; set; }
        public int? VisitForm { get; set; }

        public ChildVisitObservationStatus Status { get; set; }
        public int? TimeLength { get; set; }
        public string Reason { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class ChildScheduleObservationViewModel
    {
        public int Id { get; set; }

        public int Visit { get; set; }
        public int SessionWeek { get; set; }
        public DateTime? SessionDate { get; set; }
        public int? SessionTime { get; set; }
        public int ScheduleStatus { get; set; }
        public int VismId { get; set; }
        public int ChildId { get; set; }
        public int AdultId { get; set; }

        public string ChildFirstName { get; set; }
        public string ChildMiddleName { get; set; }
        public string ChildLastName { get; set; }

        public string ElsFirstName { get; set; }
        public string ElsMiddleName { get; set; }
        public string ElsLastName { get; set; }

        public string VismName { get; set; }

        public int ChildElsScheduleDetailId { get; set; }

        public int RelationId { get; set; }

        public string ElseOther { get; set; }

        public string AditionalActivites { get; set; }

        public string QueI { get; set; }
        public string QueII { get; set; }
        public string QueIII { get; set; }
        public string QueIV { get; set; }
        public string QueV { get; set; }
        public string QueVI { get; set; }
        public string QueVII { get; set; }
        public string QueVIIIa { get; set; }
        public string QueVIIIb { get; set; }
        public string QueIXa { get; set; }
        public string QueIXb { get; set; }
        public string QueX { get; set; }
        public string QueXI { get; set; }
        public string QueXII { get; set; }
        public int? VisitForm { get; set; }

        public ChildVisitObservationStatus Status { get; set; }
        public int? TimeLength { get; set; }
        public string Reason { get; set; }

        public string AdultFirstName { get; set; }
        public string AdultLastName { get; set; }
        public RelationshipToChild RelationshipToChild { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

    }
}

using PCHP.Core.Enums;
using System;

namespace PCHP.ViewModel
{
    public class ProviderScheduleObservationAddUpdate
    {
        public int Id { get; set; }

        public int ChildElsScheduleDetailId { get; set; }
        public DateTime VisitDate { get; set; }
        public string AnyAdult { get; set; }
        public int TotalPresentChild { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public string NamesAge { get; set; }

        public DateTime ReScheduleDate { get; set; }
        public int ReScheduleTime { get; set; }

        public ChildVisitObservationStatus ChildVisitObservationStatus { get; set; }
        public string Reason { get; set; }
        public int? VisitDuration { get; set; }

        public string QueI { get; set; }

        public string QueIIa { get; set; }
        public string QueIIb { get; set; }
        public string QueIIc { get; set; }
        public string QueIId { get; set; }
        public string QueIIe { get; set; }
        public string QueIIf { get; set; }

        public string QueIII { get; set; }
        public string QueIV { get; set; }
        public string QueV { get; set; }
        public string QueVI { get; set; }
        public string QueVII { get; set; }
        public string QueVIII { get; set; }
        public string QueIX { get; set; }
        public string QueX { get; set; }

        public string QueXIa { get; set; }
        public string QueXIb { get; set; }

        public string QueXIIa { get; set; }
        public string QueXIIb { get; set; }

        public string QueXIII { get; set; }

        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime LastEditedOn { get; set; }
    }


    public class ProviderScheduleObservationViewModel
    {
        public int Id { get; set; }

        public string ProviderFirstName { get; set; }
        public string ProviderMiddleName { get; set; }
        public string ProviderLastName { get; set; }

        public string ElsFirstName { get; set; }
        public string ElsMiddleName { get; set; }
        public string ElsLastName { get; set; }

        public string VismName { get; set; }
        
        public int ProgramSequence { get; set; }
        public int Sequence { get; set; }

        public int ChildElsScheduleDetailId { get; set; }
        public DateTime VisitDate { get; set; }
        public string AnyAdult { get; set; }
        public int TotalPresentChild { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public string NamesAge { get; set; }

        public DateTime ReScheduleDate { get; set; }
        public int ReScheduleTime { get; set; }

        public ChildVisitObservationStatus ChildVisitObservationStatus { get; set; }
        public string Reason { get; set; }
        public int? VisitDuration { get; set; }

        public string QueI { get; set; }

        public string QueIIa { get; set; }
        public string QueIIb { get; set; }
        public string QueIIc { get; set; }
        public string QueIId { get; set; }
        public string QueIIe { get; set; }
        public string QueIIf { get; set; }

        public string QueIII { get; set; }
        public string QueIV { get; set; }
        public string QueV { get; set; }
        public string QueVI { get; set; }
        public string QueVII { get; set; }
        public string QueVIII { get; set; }
        public string QueIX { get; set; }
        public string QueX { get; set; }

        public string QueXIa { get; set; }
        public string QueXIb { get; set; }

        public string QueXIIa { get; set; }
        public string QueXIIb { get; set; }

        public string QueXIII { get; set; }

        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime LastEditedOn { get; set; }

    }
}
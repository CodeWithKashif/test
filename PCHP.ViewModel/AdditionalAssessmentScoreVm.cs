using System;

namespace PCHP.ViewModel
{
    public class AdditionalAssessmentScoreVm
    {
        public int Id { get; set; }
        public double? SubscaleScoreId { get; set; }
        public string SubscaleName { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

    }
}
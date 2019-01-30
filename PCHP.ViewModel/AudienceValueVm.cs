using System;

namespace PCHP.ViewModel
{
    public class AudienceValueVm
    {
        public int Id { get; set; }
        public int AudienceId { get; set; }
        public int AudienceValueId { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
        public int AudianceTypeId { get; set; }
        public string AudianceValue { get; set; }
        public string AudianceType { get; set; }
    }

}
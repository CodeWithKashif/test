using System;
using System.Collections.Generic;

namespace PCHP.ViewModel
{
    public class AudienceVm
    {
        public int Id { get; set; }
        public int AnnouncementId { get; set; }
        public int AudienceId { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

        public List<AudienceValueVm> AudienceValue { get; set; }

        public AudienceVm()
        {
            AudienceValue = new List<AudienceValueVm>();
        }
    }
}
using System;
using PCHP.Core.Enums;

namespace PCHP.ViewModel
{
    public class SiteProgramsVm
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public ProgramType ProgramType { get; set; }
        public DateTime ProgramStartDate { get; set; }
        public DateTime? ProgramEndDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }
}
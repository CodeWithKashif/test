using System;
using PCHP.Core;
using PCHP.Core.Enums;

namespace PCHP.ViewModel
{
    public class SiteAnnualRequirementDocumentViewModel
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int Year { get; set; }
        public ProgramType ProgramType { get; set; }
        public DocumentType DocumentType { get; set; }
        public string Document { get; set; }
        public string OriginalDocument { get; set; }
        public string Comments { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

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

        public SiteAnnualRequirementDocumentViewModel()
        {
        }
    }

    public class SiteAnnualRequirementDocumentAddUpdate
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int Year { get; set; }
        public ProgramType ProgramType { get; set; }
        public DocumentType DocumentType { get; set; }
        public string Document { get; set; }
        public string OriginalDocument { get; set; }
        public string DocumentExtension { get; set; }
        public string Comments { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class SiteAnnualRequirementDocumentGridFilterVm : GridParameter
    {
        public int SiteId { get; set; }
        public ProgramType ProgramType { get; set; }
        public int Year { get; set; }
    }

    public class SiteAnnualRequirementDocumentGridResultVm
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public DocumentType DocumentType { get; set; }
        public string Document { get; set; }
        public string OriginalDocument { get; set; }
        public string Comments { get; set; }
    }


}
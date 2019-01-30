using System;
using System.Collections.Generic;
using PCHP.Core;
using PCHP.Core.Enums;

namespace PCHP.ViewModel
{
    public class SiteReferenceDocumentAddUpdate
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public SiteCertificationType Type { get; set; }
        public DateTime? Date { get; set; }
        public DocumentStatus DocumentStatus { get; set; }
        public string Documents { get; set; }
        public string OriginalDocument { get; set; }
        public string DocumentExtension { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
        
    }

    public class SiteReferenceDocumentViewModel
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public SiteCertificationType Type { get; set; }
        public DateTime? Date { get; set; }
        public DocumentStatus DocumentStatus { get; set; }
        public string Documents { get; set; }
        public string OriginalDocument { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class SiteReferenceDocumentGridResultVm
    {
        public int Id { get; set; }
        public SiteCertificationType Type { get; set; }
        public DateTime? Date { get; set; }
        public DocumentStatus DocumentStatus { get; set; }
        public string Documents { get; set; }
        public string OriginalDocument { get; set; }
    }


}
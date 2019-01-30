using System;
using PCHP.Core.Enums;

namespace PCHP.ViewModel.Site.Certification
{
    public class SiteCertificationViewModel
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int CertificateNumber { get; set; }
        public DateTime? CertificationDate { get; set; }
        public DateTime? NextCertificationDate { get; set; }
        public string CertificationFile { get; set; }
        public string OriginalDocument { get; set; }
        public int CertificationStatus { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
        public string Comment { get; set; }
    }

    public class SiteCertificationAddUpdate
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int CertificateNumber { get; set; }
        public DateTime? CertificationDate { get; set; }
        public DateTime? NextCertificationDate { get; set; }
        public string CertificationFile { get; set; }
        public string OriginalDocument { get; set; }
        public string CertificationFileExtension { get; set; }
        public CertificationStatus CertificationStatus { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
        public string Comment { get; set; }
    }

    public class SiteCertificationGridResultVm
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int CertificateNumber { get; set; }
        public DateTime? CertificationDate { get; set; }
        public DateTime? NextCertificationDate { get; set; }
        public string CertificationFile { get; set; }
        public string OriginalDocument { get; set; }
        public CertificationStatus CertificationStatus { get; set; }
    }
}

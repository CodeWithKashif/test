using PCHP.Core;
using PCHP.Core.Attributes;
using PCHP.Core.Enums;
using System;
using System.Collections.Generic;

namespace PCHP.ViewModel
{
    public class AnnouncementAddUpdate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime? RequiredBy { get; set; }
        public bool? SendViaEmail { get; set; }
        public string EnglishDescription { get; set; }
        public string AdditionalLanguages { get; set; }
        public string AdditionalLanguagesName { get; set; }
        [AlwaysUdpate]
        public string SpanishDescription { get; set; }
        public List<AudienceVm> Audience { get; set; }

        public AnnouncementAddUpdate()
        {
            Audience = new List<AudienceVm>();
        }
        public int IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

    }

    public class AnnouncementViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime? RequiredBy { get; set; }
        public bool? SendViaEmail { get; set; }
        public string EnglishDescription { get; set; }
        public string AdditionalLanguages { get; set; }
        public string AdditionalLanguagesName { get; set; }
        public string SpanishDescription { get; set; }

        public List<AudienceVm> Audience { get; set; }

        public List<AudienceValueVm> AudienceValue { get; set; }

        public AnnouncementViewModel()
        {
            Audience = new List<AudienceVm>();
            AudienceValue = new List<AudienceValueVm>();
        }
        public int IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }


    public class AnnouncementGridResultVm : TGridResultViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public string AudiencesValue { get; set; }
        public string CreatedByFirstName { get; set; }
        public string CreatedByMiddleName { get; set; }
        public string CreatedByLastName { get; set; }

        public string LastEditedFirstName { get; set; }
        public string LastEditedMiddleName { get; set; }
        public string LastEditedLastName { get; set; }
        public int IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

        public string Status { get; set; }
        public string Description { get; set; }

        public StatusType? StatusType { get; set; }

    }

    public class AnnouncementSearchRequest : GridParameter
    {
        public string Name { get; set; }
        public int? Status { get; set; }
        public int UserId { get; set; }
        public int SiteId { get; set; }
        public StatusType? StatusType { get; set; } 
    }

    public class AnnouncementUserAdd 
    {
        public int UserId { get; set; }
        public int AnnouncementId { get; set; }
        public bool IsRead { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
        public bool IsDeleted { get; set; }

    }
    public class AnnouncementSiteAdd
    {
        public int SiteId { get; set; }
        public int AnnouncementId { get; set; }
        public bool IsRead { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
        public bool IsDeleted { get; set; }

    }
    public class AnnouncementEmailLogAddUpdate
    {
        public int Id { get; set; }
        public int AnnouncmentId { get; set; }
        public int UserId { get; set; }
        public DateTime SendDate { get; set; }
        public bool? MailSend { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
        public EmailType EmailType { get; set; }
    }
}
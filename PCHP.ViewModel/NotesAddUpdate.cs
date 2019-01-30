using PCHP.Core;
using System;

namespace PCHP.ViewModel
{
    public class NotesAddUpdate
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public string OriginalFileName { get; set; }

        public string FileName { get; set; }
        public string FileExtension { get; set; }

        public int PrivacyLevel { get; set; }
        public int? UserId { get; set; }
        public int? SiteId { get; set; }
        public int? ChildId { get; set; }
        public int? ProviderId { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class NotesViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public string OriginalFileName { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }

        public int PrivacyLevel { get; set; }
        public int? UserId { get; set; }
        public int? SiteId { get; set; }
        public int? ChildId { get; set; }
        public int? ProviderId { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }
    }

    public class NotesGridResultVm : TGridResultViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public string OriginalFileName { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }

        public int PrivacyLevel { get; set; }

        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime? LastEditedOn { get; set; }

    }

    public class NotesSearchRequest : GridParameter
    {
        public DateTime? Date { get; set; }

        public int UserId { get; set; } // login user

        public int? StaffId { get; set; } // can be SC, ESL and SA etc 

        public int? SiteId { get; set; }

        public int? ChildId { get; set; }

        public int? ProviderId { get; set; }
    }
}